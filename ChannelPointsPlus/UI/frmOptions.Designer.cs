﻿namespace ChannelPointsPlus
{
    partial class frmOptions
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
            this.cbTrayMini = new System.Windows.Forms.CheckBox();
            this.btnResetID = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ResetTwitchLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTrayMini
            // 
            this.cbTrayMini.AutoSize = true;
            this.cbTrayMini.Checked = true;
            this.cbTrayMini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrayMini.ForeColor = System.Drawing.Color.White;
            this.cbTrayMini.Location = new System.Drawing.Point(16, 15);
            this.cbTrayMini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTrayMini.Name = "cbTrayMini";
            this.cbTrayMini.Size = new System.Drawing.Size(121, 20);
            this.cbTrayMini.TabIndex = 0;
            this.cbTrayMini.Text = "Minimize to tray.";
            this.cbTrayMini.UseVisualStyleBackColor = true;
            this.cbTrayMini.CheckedChanged += new System.EventHandler(this.cbTrayMini_CheckedChanged);
            // 
            // btnResetID
            // 
            this.btnResetID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetID.ForeColor = System.Drawing.Color.White;
            this.btnResetID.Location = new System.Drawing.Point(16, 58);
            this.btnResetID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetID.Name = "btnResetID";
            this.btnResetID.Size = new System.Drawing.Size(135, 28);
            this.btnResetID.TabIndex = 1;
            this.btnResetID.Text = "Reset ChannelID";
            this.btnResetID.UseVisualStyleBackColor = true;
            this.btnResetID.Click += new System.EventHandler(this.btnResetID_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(336, 319);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ResetTwitchLoginButton
            // 
            this.ResetTwitchLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetTwitchLoginButton.ForeColor = System.Drawing.Color.White;
            this.ResetTwitchLoginButton.Location = new System.Drawing.Point(16, 94);
            this.ResetTwitchLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetTwitchLoginButton.Name = "ResetTwitchLoginButton";
            this.ResetTwitchLoginButton.Size = new System.Drawing.Size(160, 28);
            this.ResetTwitchLoginButton.TabIndex = 3;
            this.ResetTwitchLoginButton.Text = "Reset Twitch Login";
            this.ResetTwitchLoginButton.UseVisualStyleBackColor = true;
            this.ResetTwitchLoginButton.Click += new System.EventHandler(this.ResetTwitchLoginButton_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(452, 362);
            this.ControlBox = false;
            this.Controls.Add(this.ResetTwitchLoginButton);
            this.Controls.Add(this.cbTrayMini);
            this.Controls.Add(this.btnResetID);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(449, 355);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StreamAssistant";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTrayMini;
        private System.Windows.Forms.Button btnResetID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button ResetTwitchLoginButton;
    }
}