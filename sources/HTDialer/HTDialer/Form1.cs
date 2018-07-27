using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using HTDialer.Utils;
using System.Diagnostics;
using System.Windows.Automation;

/**
 *
 * test: +7(123)123-45-67
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer
{
    public partial class Form1 : Form
    {
        private const int BALLOON_TO = 500;
        private ConfigurationManager configurationManager;
        private HotkeyMonitor hotkeyMonitor;
        private ClipboardMonitor clipboardMonitor;
        private DestinationValidator destinationValidator;
        private bool _flagHttpClientBusy = false;
        private string _numberOriginal;

        public Form1()
        {
            InitializeComponent();
            configurationManager = new ConfigurationManager();
            destinationValidator = new DestinationValidator();
            hotkeyMonitor = new HotkeyMonitor();
            clipboardMonitor = new ClipboardMonitor();
            // load config
            try
            {
                configurationManager.Load();
            }
            catch (Exception exc)
            {
                SimpleLogger.Log("ERROR: can't read configuration, exc=" + exc);
                MessageBox.Show(exc.ToString(), "Can't load configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            // regexp
            try
            {
                destinationValidator.ApplyRegex(configurationManager.Configuration().Regex);
            }
            catch (Exception exc)
            {
                // is not critical error, you can redefine it
                destinationValidator.ApplyRegex(null);
                Log("WARN: malformed pattern: " + configurationManager.Configuration().Regex + ", exp: " + exc);
            }
            // hotkeys
            hotkeyMonitor.KeyPressed += new EventHandler<HTDialer.Utils.HotkeyMonitor.KeyPressedEventArgs>(hook_hotkey_pressed);
            try
            {
                hotkeyMonitor.SetKey(configurationManager.Configuration().Hotkey);
            }
            catch (Exception exc)
            {
                Log("WARN: can't install hotkey, exc=" + exc);
            }
            // clipboard
            clipboardMonitor.ClipboardEvent += new EventHandler<HTDialer.Utils.ClipboardMonitor.ClipboardEventArgs>(hook_clipboard_event);

            // update UI
            string[] s = String.IsNullOrEmpty(configurationManager.Configuration().Credentials) ? null : configurationManager.Configuration().Credentials.Split(':');
            this.fieldHotkey.Text = configurationManager.Configuration().Hotkey;
            this.fieldHttpUsername.Text = (s != null ? s[0] : null);
            this.fieldHttpPassword.Text = (s != null ? s[1] : null);
            this.fieldUrl.Text = configurationManager.Configuration().Url;
            this.fieldRegex.Text = configurationManager.Configuration().Regex;
            // do hide
            //this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            //
            Log("ready");
            Log("test number: +7 (123) 123-45-67");
        }

        public void Log(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), new object[] { msg });
                return;
            }
            string str = fieldLogArea.Text;
            if (str != null && str.Length > 512)
                fieldLogArea.Text = msg + Environment.NewLine;
            else
                fieldLogArea.Text += msg + Environment.NewLine;
        }

        private void HttpReqFn(object url)
        {
            if (_flagHttpClientBusy)
            {
                Log("Try again later, another request active");
                return;
            }
            //
            _flagHttpClientBusy = true;
            try
            {
                string rsp = HttpHelper.HttpGet(configurationManager.Configuration().Credentials, (string)url);
                Log("http-response: " + rsp);
            }
            catch (Exception e)
            {
                ShowBallon("Call failed", "Unexpected error, see log for details");
                Log("ERROR: " + url +", exception: " + e);
            }
            finally
            {
                _flagHttpClientBusy = false;
            }
        }

        private void DoMakeCall()
        {
            string n = fieldLastNumber.Text;
            if (String.IsNullOrEmpty(n))
            {
                ShowBallon(null, "No number for dial");
                return;
            }
            ShowBallon("Dialing...", _numberOriginal);
            //
            string url = configurationManager.Configuration().Url.Replace("%number%", n);
            Thread th = new Thread(HttpReqFn);
            th.Start(url);
        }

        private void ShowBallon(string h, string b)
        {
            notifyIcon1.BalloonTipTitle = h;
            notifyIcon1.BalloonTipText = b;
            notifyIcon1.ShowBalloonTip(BALLOON_TO);
        }

        // ===============================================================================================================================
        // events
        // ===============================================================================================================================
        private void hook_hotkey_pressed(object sender, HTDialer.Utils.HotkeyMonitor.KeyPressedEventArgs e)
        {
            //clipboardMonitor.CopyActiveSelection();
            DoMakeCall();
        }

        private void hook_clipboard_event(object sender, HTDialer.Utils.ClipboardMonitor.ClipboardEventArgs e)
        {
            string dst = e.Text;
            _numberOriginal = e.Text;
            //
            if (dst.Length > 64)
            {
                return;
            }
            //Log("CLIPBOARD: " + dst);
            // format and check 
            dst = destinationValidator.Format(dst);
            if (!destinationValidator.IsValid(dst))
            {
                return;
            }
            fieldLastNumber.Text = dst;
            ShowBallon("Number captured", _numberOriginal);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string hkey = fieldHotkey.Text;
            string regex = fieldRegex.Text;
            string url = fieldUrl.Text;
            string credentialsUN = fieldHttpUsername.Text;
            string credentialsPW = fieldHttpPassword.Text;
            //
            if (!hotkeyMonitor.IsValid(hkey))
            {
                MessageBox.Show("Hotkey is incorrect, please define it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please define a URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            configurationManager.Configuration().Regex = regex;
            configurationManager.Configuration().Hotkey = hkey;
            configurationManager.Configuration().Url = url;
            configurationManager.Configuration().Credentials = (String.IsNullOrEmpty(credentialsUN) ? "" : credentialsUN + ":" + credentialsPW);
            //            
            try
            {
                hotkeyMonitor.SetKey(hkey);
                destinationValidator.ApplyRegex(regex);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Apply failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 
            configurationManager.Save();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized || this.Visible == false)
            {
                //Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            DoMakeCall();
        }

        private void buttonTestregex_Click(object sender, EventArgs e)
        {
            string n = destinationValidator.Format(fieldLastNumber.Text);
            Log("destinatin: " + n + ", validation: " + destinationValidator.IsValid(n));
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to close the application?", "Closing application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fieldRegex_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fieldLogArea.Text = "";
        }

    }
}
