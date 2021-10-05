
namespace ChannelPointsPlus
{
    partial class frmStartUpPrograms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartUpPrograms));
            this.AddProgramButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartUpListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SpeechChatCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddProgramButton
            // 
            this.AddProgramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.AddProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProgramButton.ForeColor = System.Drawing.Color.Silver;
            this.AddProgramButton.Location = new System.Drawing.Point(12, 75);
            this.AddProgramButton.Name = "AddProgramButton";
            this.AddProgramButton.Size = new System.Drawing.Size(98, 35);
            this.AddProgramButton.TabIndex = 30;
            this.AddProgramButton.Text = "Add program";
            this.AddProgramButton.UseVisualStyleBackColor = false;
            this.AddProgramButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Start Up Programs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Here you can add any executable program to start when ChannelPointsPlus is starti" +
    "ng up. \r\nAll programs you need for streaming will be started up with one click o" +
    "n the button. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Programs List";
            // 
            // StartUpListBox
            // 
            this.StartUpListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.StartUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartUpListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartUpListBox.ForeColor = System.Drawing.Color.White;
            this.StartUpListBox.FormattingEnabled = true;
            this.StartUpListBox.ItemHeight = 20;
            this.StartUpListBox.Location = new System.Drawing.Point(13, 178);
            this.StartUpListBox.Name = "StartUpListBox";
            this.StartUpListBox.Size = new System.Drawing.Size(420, 260);
            this.StartUpListBox.TabIndex = 35;
            this.StartUpListBox.SelectedIndexChanged += new System.EventHandler(this.StartUpListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(331, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Start All Programs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(117, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 37;
            this.button2.Text = "Delete program";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpeechChatCheckbox
            // 
            this.SpeechChatCheckbox.AutoSize = true;
            this.SpeechChatCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpeechChatCheckbox.ForeColor = System.Drawing.Color.White;
            this.SpeechChatCheckbox.Location = new System.Drawing.Point(627, 17);
            this.SpeechChatCheckbox.Name = "SpeechChatCheckbox";
            this.SpeechChatCheckbox.Size = new System.Drawing.Size(161, 17);
            this.SpeechChatCheckbox.TabIndex = 38;
            this.SpeechChatCheckbox.Text = "Always start programs at start";
            this.SpeechChatCheckbox.UseVisualStyleBackColor = true;
            this.SpeechChatCheckbox.CheckedChanged += new System.EventHandler(this.SpeechChatCheckbox_CheckedChanged);
            // 
            // frmStartUpPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpeechChatCheckbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartUpListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddProgramButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartUpPrograms";
            this.Text = "StartUpPrograms";
            this.Load += new System.EventHandler(this.frmStartUpPrograms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddProgramButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox StartUpListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox SpeechChatCheckbox;
    }
}