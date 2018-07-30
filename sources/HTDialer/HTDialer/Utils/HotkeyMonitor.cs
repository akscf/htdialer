using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer.Utils
{
    class HotkeyMonitor : IDisposable
    {

        public event EventHandler<KeyPressedEventArgs> KeyPressed;
        private Regex rx;
        private String oldKey;
        private Window _window = new Window();
        private int _currentId = 0;

        public HotkeyMonitor()
        {
            rx = new Regex("^(alt|ctrl|shift|win)(\\++(alt|ctrl|shift|win))*?\\++.*$");
            _window.KeyPressed += delegate(object sender, KeyPressedEventArgs args)
            {
                if (KeyPressed != null)
                    KeyPressed(this, args);
            };
        }

        // =======================================================================================================================
        // api
        // =======================================================================================================================
        public bool IsValid(String key)
        {
            return !String.IsNullOrEmpty(key) && rx.IsMatch(key.ToLower());
        }

        public void SetKey(String key)
        {
            if (oldKey == null || String.Compare(oldKey, key, true) != 0)
            {
                // remove previous
                if (oldKey != null)
                {
                    for (int i = _currentId; i > 0; i--)
                    {
                        Win32Helper.UnregisterHotKey(_window.Handle, i);
                    }

                }
                oldKey = key;
                ModifierKeys modifier = 0;
                Keys keys = 0;
                // parse
                String[] t = key.ToLower().Split('+');
                foreach (var v in t)
                {
                    bool mod = false;
                    switch (v)
                    {
                        case "alt":
                            modifier |= ModifierKeys.Alt; mod = true; break;
                        case "ctrl":
                            modifier |= ModifierKeys.Control; mod = true; break;
                        case "shift":
                            modifier |= ModifierKeys.Shift; mod = true; break;
                        case "win":
                            modifier |= ModifierKeys.Win; mod = true; break;
                    }
                    if (!mod)
                    {
                        Enum.TryParse(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(v), out keys);
                    }
                }
                // register keys
                _currentId = _currentId + 1;
                if (!Win32Helper.RegisterHotKey(_window.Handle, _currentId, (uint)modifier, (uint)keys))
                {
                    throw new InvalidOperationException("Couldn't register the hotkey.");
                }
            }
        }

        #region IDisposable Members
        public void Dispose()
        {
            for (int i = _currentId; i > 0; i--)
            {
                Win32Helper.UnregisterHotKey(_window.Handle, i);
            }
            _window.Dispose();
        }
        #endregion

        // =======================================================================================================================
        // helper clesses
        // =======================================================================================================================
        public class KeyPressedEventArgs : EventArgs
        {
            private ModifierKeys _modifier;
            private Keys _key;

            internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
            {
                _modifier = modifier;
                _key = key;
            }

            public ModifierKeys Modifier
            {
                get { return _modifier; }
            }

            public Keys Key
            {
                get { return _key; }
            }
        }
        public enum ModifierKeys : uint
        {
            Alt = 1,
            Control = 2,
            Shift = 4,
            Win = 8
        }

        private class Window : NativeWindow, IDisposable
        {
            private static int WM_HOTKEY = 0x0312;
            public event EventHandler<KeyPressedEventArgs> KeyPressed;

            public Window()
            {
                this.CreateHandle(new CreateParams());
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == WM_HOTKEY)
                {
                    Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                    ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

                    if (KeyPressed != null)
                    {
                        KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                    }
                }
            }

            #region IDisposable Members
            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }
    }
}
