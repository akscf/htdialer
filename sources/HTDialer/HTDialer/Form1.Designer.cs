﻿namespace HTDialer
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
            this.fieldRegex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldHotkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fieldLogArea = new System.Windows.Forms.TextBox();
            this.fieldLastNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(401, 106);
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
            this.groupBox1.Controls.Add(this.fieldRegex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonApply);
            this.groupBox1.Controls.Add(this.fieldUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fieldHotkey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // fieldRegex
            // 
            this.fieldRegex.Location = new System.Drawing.Point(60, 80);
            this.fieldRegex.Name = "fieldRegex";
            this.fieldRegex.Size = new System.Drawing.Size(416, 20);
            this.fieldRegex.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Regex:";
            // 
            // fieldUrl
            // 
            this.fieldUrl.Location = new System.Drawing.Point(60, 51);
            this.fieldUrl.Name = "fieldUrl";
            this.fieldUrl.Size = new System.Drawing.Size(416, 20);
            this.fieldUrl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // fieldHotkey
            // 
            this.fieldHotkey.Location = new System.Drawing.Point(60, 19);
            this.fieldHotkey.Name = "fieldHotkey";
            this.fieldHotkey.Size = new System.Drawing.Size(416, 20);
            this.fieldHotkey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotkey:";
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.ForeColor = System.Drawing.Color.Red;
            this.buttonCloseApp.Location = new System.Drawing.Point(414, 347);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
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
            this.groupBox3.Location = new System.Drawing.Point(13, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last dialed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 375);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(526, 410);
            this.MinimumSize = new System.Drawing.Size(526, 410);
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
    }
}
