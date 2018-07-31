using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer.Utils
{
    class ClipboardMonitor
    {
        public event EventHandler<ClipboardEventArgs> ClipboardEvent;
        private Window _window = new Window();

        public ClipboardMonitor()
        {
            _window.clipboardEvent += delegate(object sender, ClipboardEventArgs args)
            {
                if (ClipboardEvent != null)
                    ClipboardEvent(this, args);
            };
        }

        #region IDisposable Members
        public void Dispose()
        {
            _window.Dispose();
        }
        #endregion

        // =======================================================================================================================
        // helper clesses
        // =======================================================================================================================
        public class ClipboardEventArgs : EventArgs
        {
            private string _text;

            internal ClipboardEventArgs(string text)
            {
                _text = text;
            }

            public string Text
            {
                get { return _text; }
            }

        }
        private class Window : NativeWindow, IDisposable
        {
            private const int WM_DRAWCLIPBOARD = 0x308;
            private const int WM_CLIPBOARD_CHANGECHAIN = 0x30D;
            private IntPtr _clipboardViewerNext;
            public event EventHandler<ClipboardEventArgs> clipboardEvent;

            public Window()
            {
                this.CreateHandle(new CreateParams());
                this._clipboardViewerNext = Win32Helper.SetClipboardViewer(this.Handle);
            }

            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case WM_DRAWCLIPBOARD:
                        if (Clipboard.ContainsText())
                        {
                            var selectedText = Clipboard.GetText();
                            if (!String.IsNullOrEmpty(selectedText) && clipboardEvent != null)
                            {
                                clipboardEvent(this, new ClipboardEventArgs(selectedText));
                            }

                        }
                        Win32Helper.SendMessage(_clipboardViewerNext, m.Msg, m.WParam, m.LParam);
                        break;
                    case WM_CLIPBOARD_CHANGECHAIN:
                        if (m.WParam == _clipboardViewerNext)
                            _clipboardViewerNext = m.LParam;
                        else
                            Win32Helper.SendMessage(_clipboardViewerNext, m.Msg, m.WParam, m.LParam);
                        break;

                    default:
                        base.WndProc(ref m);
                        break;
                }
            }

            #region IDisposable Members
            public void Dispose()
            {
                Win32Helper.ChangeClipboardChain(this.Handle, _clipboardViewerNext);
                this.DestroyHandle();
            }

            #endregion
        }
    }
}
