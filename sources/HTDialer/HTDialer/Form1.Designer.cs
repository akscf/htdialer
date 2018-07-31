namespace HTDialer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonApply = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fieldShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.fieldHttpUsername = new System.Windows.Forms.TextBox();
            this.fieldHttpPassword = new System.Windows.Forms.TextBox();
            this.fieldRegex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldHotkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fieldLogArea = new System.Windows.Forms.TextBox();
            this.fieldLastNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fieldCutchars = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(405, 210);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.toolTip1.SetToolTip(this.buttonApply, "Apply and save current settings");
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HTDialer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fieldCutchars);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fieldHotkey);
            this.groupBox1.Controls.Add(this.fieldShowInTaskbar);
            this.groupBox1.Controls.Add(this.fieldHttpUsername);
            this.groupBox1.Controls.Add(this.fieldHttpPassword);
            this.groupBox1.Controls.Add(this.fieldRegex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonApply);
            this.groupBox1.Controls.Add(this.fieldUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Other:";
            // 
            // fieldShowInTaskbar
            // 
            this.fieldShowInTaskbar.AutoSize = true;
            this.fieldShowInTaskbar.Location = new System.Drawing.Point(107, 157);
            this.fieldShowInTaskbar.Name = "fieldShowInTaskbar";
            this.fieldShowInTaskbar.Size = new System.Drawing.Size(102, 17);
            this.fieldShowInTaskbar.TabIndex = 13;
            this.fieldShowInTaskbar.Text = "Show in taskbar";
            this.fieldShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // fieldHttpUsername
            // 
            this.fieldHttpUsername.Location = new System.Drawing.Point(106, 131);
            this.fieldHttpUsername.Name = "fieldHttpUsername";
            this.fieldHttpUsername.Size = new System.Drawing.Size(134, 20);
            this.fieldHttpUsername.TabIndex = 12;
            // 
            // fieldHttpPassword
            // 
            this.fieldHttpPassword.Location = new System.Drawing.Point(309, 131);
            this.fieldHttpPassword.Name = "fieldHttpPassword";
            this.fieldHttpPassword.Size = new System.Drawing.Size(167, 20);
            this.fieldHttpPassword.TabIndex = 11;
            // 
            // fieldRegex
            // 
            this.fieldRegex.Location = new System.Drawing.Point(106, 22);
            this.fieldRegex.Name = "fieldRegex";
            this.fieldRegex.Size = new System.Drawing.Size(370, 20);
            this.fieldRegex.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Validation pattern:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // fieldHotkey
            // 
            this.fieldHotkey.Location = new System.Drawing.Point(106, 74);
            this.fieldHotkey.Name = "fieldHotkey";
            this.fieldHotkey.Size = new System.Drawing.Size(370, 20);
            this.fieldHotkey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotkey:";
            // 
            // fieldUrl
            // 
            this.fieldUrl.Location = new System.Drawing.Point(107, 100);
            this.fieldUrl.Name = "fieldUrl";
            this.fieldUrl.Size = new System.Drawing.Size(370, 20);
            this.fieldUrl.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.ForeColor = System.Drawing.Color.Red;
            this.buttonCloseApp.Location = new System.Drawing.Point(424, 450);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseApp.TabIndex = 10;
            this.buttonCloseApp.Text = "Exit";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(401, 45);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(75, 23);
            this.buttonCall.TabIndex = 5;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fieldLogArea);
            this.groupBox2.Location = new System.Drawing.Point(13, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // fieldLogArea
            // 
            this.fieldLogArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldLogArea.Location = new System.Drawing.Point(12, 19);
            this.fieldLogArea.Multiline = true;
            this.fieldLogArea.Name = "fieldLogArea";
            this.fieldLogArea.ReadOnly = true;
            this.fieldLogArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fieldLogArea.Size = new System.Drawing.Size(465, 82);
            this.fieldLogArea.TabIndex = 1;
            // 
            // fieldLastNumber
            // 
            this.fieldLastNumber.Location = new System.Drawing.Point(6, 19);
            this.fieldLastNumber.Name = "fieldLastNumber";
            this.fieldLastNumber.ReadOnly = true;
            this.fieldLastNumber.Size = new System.Drawing.Size(470, 20);
            this.fieldLastNumber.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCall);
            this.groupBox3.Controls.Add(this.fieldLastNumber);
            this.groupBox3.Location = new System.Drawing.Point(14, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last dialed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cut chars:";
            // 
            // fieldCutchars
            // 
            this.fieldCutchars.Location = new System.Drawing.Point(106, 48);
            this.fieldCutchars.Name = "fieldCutchars";
            this.fieldCutchars.Size = new System.Drawing.Size(370, 20);
            this.fieldCutchars.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(526, 520);
            this.MinimumSize = new System.Drawing.Size(526, 520);
            this.Name = "Form1";
            this.Text = "HTDialer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fieldUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldHotkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fieldLogArea;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.TextBox fieldRegex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fieldLastNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fieldHttpPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldHttpUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox fieldShowInTaskbar;
        private System.Windows.Forms.TextBox fieldCutchars;
        private System.Windows.Forms.Label label7;
    }
}

