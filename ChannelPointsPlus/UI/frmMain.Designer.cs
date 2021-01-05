namespace ChannelPointsPlus
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lstbxSoundsRewards = new System.Windows.Forms.ListBox();
            this.lstbxSoundsPaths = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditTitle = new System.Windows.Forms.Button();
            this.btnEditSound = new System.Windows.Forms.Button();
            this.AddSceneButton = new System.Windows.Forms.Button();
            this.DeleteSceneButton = new System.Windows.Forms.Button();
            this.AddSceneSourceButton = new System.Windows.Forms.Button();
            this.DeleteSceneSourceButton = new System.Windows.Forms.Button();
            this.TwitchConnectButton = new System.Windows.Forms.Button();
            this.AddVideoButton = new System.Windows.Forms.Button();
            this.DeleteVideoButton = new System.Windows.Forms.Button();
            this.TTSSettingsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SceneRewards = new System.Windows.Forms.ListBox();
            this.SceneNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SceneChangeDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.VideoRewards = new System.Windows.Forms.ListBox();
            this.VideoUrls = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SceneSourceRewards = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SceneSourceNames = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SceneSourceChangeDuration = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SceneChangeEventsInfo = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AudioEventsInfo = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TTSSettingsPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.TTSSubscribersOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SpeechChatComboBox = new System.Windows.Forms.ComboBox();
            this.TwitchLoginPanel = new System.Windows.Forms.Panel();
            this.TwitchOAuthInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TwitchUsernameInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SpeechChatCheckbox = new System.Windows.Forms.CheckBox();
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneChangeDuration)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SceneSourceChangeDuration)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.TTSSettingsPanel.SuspendLayout();
            this.TwitchLoginPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "ChannelPointsPlus";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(16, 297);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(251, 45);
            this.trkVolume.TabIndex = 0;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            this.trkVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrkVolume_MouseUp);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(267, 297);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(28, 20);
            this.txtVolume.TabIndex = 1;
            this.txtVolume.Text = "100";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(16, 281);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Volume";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(64, 288);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(230, 2);
            this.lblLine.TabIndex = 3;
            // 
            // lstbxSoundsRewards
            // 
            this.lstbxSoundsRewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.lstbxSoundsRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxSoundsRewards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbxSoundsRewards.FormattingEnabled = true;
            this.lstbxSoundsRewards.Items.AddRange(new object[] {
            "Highlight my Message",
            "Modify a Single Emote",
            "Unlock a Random Sub Emote",
            "Choose an emote to unlock",
            "T1 Sub"});
            this.lstbxSoundsRewards.Location = new System.Drawing.Point(19, 87);
            this.lstbxSoundsRewards.Name = "lstbxSoundsRewards";
            this.lstbxSoundsRewards.Size = new System.Drawing.Size(136, 93);
            this.lstbxSoundsRewards.TabIndex = 4;
            this.lstbxSoundsRewards.SelectedIndexChanged += new System.EventHandler(this.lstbxSoundsRewards_SelectedIndexChanged);
            this.lstbxSoundsRewards.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstbxSoundsRewards_MouseMove);
            // 
            // lstbxSoundsPaths
            // 
            this.lstbxSoundsPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.lstbxSoundsPaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxSoundsPaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbxSoundsPaths.FormattingEnabled = true;
            this.lstbxSoundsPaths.Items.AddRange(new object[] {
            "C:\\test1",
            "C:\\test2",
            "C:\\test3",
            "C:\\test4",
            "C:\\test5"});
            this.lstbxSoundsPaths.Location = new System.Drawing.Point(156, 87);
            this.lstbxSoundsPaths.Name = "lstbxSoundsPaths";
            this.lstbxSoundsPaths.Size = new System.Drawing.Size(139, 93);
            this.lstbxSoundsPaths.TabIndex = 5;
            this.lstbxSoundsPaths.SelectedIndexChanged += new System.EventHandler(this.lstbxSoundsPaths_SelectedIndexChanged);
            this.lstbxSoundsPaths.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstbxSoundsPaths_MouseMove);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(19, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Sound";
            this.toolTip1.SetToolTip(this.btnAdd, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.Silver;
            this.btnTest.Location = new System.Drawing.Point(117, 188);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test Sound";
            this.toolTip1.SetToolTip(this.btnTest, "Tests the sound as if someone had redemed the reward.");
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Silver;
            this.btnRemove.Location = new System.Drawing.Point(215, 188);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Delete Sound";
            this.toolTip1.SetToolTip(this.btnRemove, "Deletes the currently highlighted sound.");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(19, 247);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(276, 23);
            this.btnStopAll.TabIndex = 12;
            this.btnStopAll.Text = "Emergency Stop";
            this.toolTip1.SetToolTip(this.btnStopAll, "Stops all playing sounds.");
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(74, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(71, 35);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Settings ⚙️";
            this.toolTip1.SetToolTip(this.btnSettings, "Opens the settings dialog.");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnEditTitle
            // 
            this.btnEditTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTitle.ForeColor = System.Drawing.Color.Silver;
            this.btnEditTitle.Location = new System.Drawing.Point(19, 218);
            this.btnEditTitle.Name = "btnEditTitle";
            this.btnEditTitle.Size = new System.Drawing.Size(133, 23);
            this.btnEditTitle.TabIndex = 14;
            this.btnEditTitle.Text = "Edit Title";
            this.toolTip1.SetToolTip(this.btnEditTitle, "Edits the title of the currently selected reward.");
            this.btnEditTitle.UseVisualStyleBackColor = true;
            this.btnEditTitle.Click += new System.EventHandler(this.btnEditTitle_Click);
            // 
            // btnEditSound
            // 
            this.btnEditSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSound.ForeColor = System.Drawing.Color.Silver;
            this.btnEditSound.Location = new System.Drawing.Point(159, 218);
            this.btnEditSound.Name = "btnEditSound";
            this.btnEditSound.Size = new System.Drawing.Size(136, 23);
            this.btnEditSound.TabIndex = 15;
            this.btnEditSound.Text = "Edit Sound";
            this.toolTip1.SetToolTip(this.btnEditSound, "Opens the file select dialog to change the sound associated with the currently se" +
        "lected reward.");
            this.btnEditSound.UseVisualStyleBackColor = true;
            this.btnEditSound.Click += new System.EventHandler(this.btnEditSound_Click);
            // 
            // AddSceneButton
            // 
            this.AddSceneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSceneButton.ForeColor = System.Drawing.Color.Silver;
            this.AddSceneButton.Location = new System.Drawing.Point(18, 188);
            this.AddSceneButton.Name = "AddSceneButton";
            this.AddSceneButton.Size = new System.Drawing.Size(80, 23);
            this.AddSceneButton.TabIndex = 21;
            this.AddSceneButton.Text = "Add Scene";
            this.toolTip1.SetToolTip(this.AddSceneButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.AddSceneButton.UseVisualStyleBackColor = true;
            this.AddSceneButton.Click += new System.EventHandler(this.AddSceneButton_Click);
            // 
            // DeleteSceneButton
            // 
            this.DeleteSceneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSceneButton.ForeColor = System.Drawing.Color.Silver;
            this.DeleteSceneButton.Location = new System.Drawing.Point(179, 188);
            this.DeleteSceneButton.Name = "DeleteSceneButton";
            this.DeleteSceneButton.Size = new System.Drawing.Size(80, 23);
            this.DeleteSceneButton.TabIndex = 22;
            this.DeleteSceneButton.Text = "Delete Scene";
            this.toolTip1.SetToolTip(this.DeleteSceneButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.DeleteSceneButton.UseVisualStyleBackColor = true;
            this.DeleteSceneButton.Click += new System.EventHandler(this.DeleteSceneButton_Click);
            // 
            // AddSceneSourceButton
            // 
            this.AddSceneSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSceneSourceButton.ForeColor = System.Drawing.Color.Silver;
            this.AddSceneSourceButton.Location = new System.Drawing.Point(18, 188);
            this.AddSceneSourceButton.Name = "AddSceneSourceButton";
            this.AddSceneSourceButton.Size = new System.Drawing.Size(80, 23);
            this.AddSceneSourceButton.TabIndex = 21;
            this.AddSceneSourceButton.Text = "Add Scene";
            this.toolTip1.SetToolTip(this.AddSceneSourceButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.AddSceneSourceButton.UseVisualStyleBackColor = true;
            this.AddSceneSourceButton.Click += new System.EventHandler(this.AddSceneSourceButton_Click);
            // 
            // DeleteSceneSourceButton
            // 
            this.DeleteSceneSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSceneSourceButton.ForeColor = System.Drawing.Color.Silver;
            this.DeleteSceneSourceButton.Location = new System.Drawing.Point(179, 188);
            this.DeleteSceneSourceButton.Name = "DeleteSceneSourceButton";
            this.DeleteSceneSourceButton.Size = new System.Drawing.Size(80, 23);
            this.DeleteSceneSourceButton.TabIndex = 22;
            this.DeleteSceneSourceButton.Text = "Delete Scene";
            this.toolTip1.SetToolTip(this.DeleteSceneSourceButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.DeleteSceneSourceButton.UseVisualStyleBackColor = true;
            this.DeleteSceneSourceButton.Click += new System.EventHandler(this.DeleteSceneSourceButton_Click);
            // 
            // TwitchConnectButton
            // 
            this.TwitchConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwitchConnectButton.ForeColor = System.Drawing.Color.Silver;
            this.TwitchConnectButton.Location = new System.Drawing.Point(49, 87);
            this.TwitchConnectButton.Name = "TwitchConnectButton";
            this.TwitchConnectButton.Size = new System.Drawing.Size(134, 35);
            this.TwitchConnectButton.TabIndex = 28;
            this.TwitchConnectButton.Text = "Connect";
            this.toolTip1.SetToolTip(this.TwitchConnectButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.TwitchConnectButton.UseVisualStyleBackColor = true;
            this.TwitchConnectButton.Click += new System.EventHandler(this.TwitchConnectButton_Click);
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVideoButton.ForeColor = System.Drawing.Color.Silver;
            this.AddVideoButton.Location = new System.Drawing.Point(18, 188);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(80, 23);
            this.AddVideoButton.TabIndex = 21;
            this.AddVideoButton.Text = "Add Video";
            this.toolTip1.SetToolTip(this.AddVideoButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.AddVideoButton.UseVisualStyleBackColor = true;
            this.AddVideoButton.Click += new System.EventHandler(this.AddVideoButton_Click);
            // 
            // DeleteVideoButton
            // 
            this.DeleteVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteVideoButton.ForeColor = System.Drawing.Color.Silver;
            this.DeleteVideoButton.Location = new System.Drawing.Point(215, 188);
            this.DeleteVideoButton.Name = "DeleteVideoButton";
            this.DeleteVideoButton.Size = new System.Drawing.Size(80, 23);
            this.DeleteVideoButton.TabIndex = 22;
            this.DeleteVideoButton.Text = "Delete Scene";
            this.toolTip1.SetToolTip(this.DeleteVideoButton, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.DeleteVideoButton.UseVisualStyleBackColor = true;
            this.DeleteVideoButton.Click += new System.EventHandler(this.DeleteVideoButton_Click);
            // 
            // TTSSettingsButton
            // 
            this.TTSSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.TTSSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTSSettingsButton.ForeColor = System.Drawing.Color.Silver;
            this.TTSSettingsButton.Location = new System.Drawing.Point(232, 17);
            this.TTSSettingsButton.Name = "TTSSettingsButton";
            this.TTSSettingsButton.Size = new System.Drawing.Size(25, 25);
            this.TTSSettingsButton.TabIndex = 30;
            this.TTSSettingsButton.Text = "⚙️";
            this.toolTip1.SetToolTip(this.TTSSettingsButton, "Opens the settings dialog.");
            this.TTSSettingsButton.UseVisualStyleBackColor = false;
            this.TTSSettingsButton.Click += new System.EventHandler(this.TTSSettingsButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(151, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Start-Up Programs ⚙";
            this.toolTip1.SetToolTip(this.button1, "Opens the settings dialog.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SceneRewards
            // 
            this.SceneRewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.SceneRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneRewards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SceneRewards.FormattingEnabled = true;
            this.SceneRewards.Location = new System.Drawing.Point(18, 87);
            this.SceneRewards.Name = "SceneRewards";
            this.SceneRewards.Size = new System.Drawing.Size(120, 93);
            this.SceneRewards.TabIndex = 17;
            this.SceneRewards.SelectedIndexChanged += new System.EventHandler(this.SceneRewards_SelectedIndexChanged);
            // 
            // SceneNames
            // 
            this.SceneNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.SceneNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SceneNames.FormattingEnabled = true;
            this.SceneNames.Location = new System.Drawing.Point(139, 87);
            this.SceneNames.Name = "SceneNames";
            this.SceneNames.Size = new System.Drawing.Size(120, 93);
            this.SceneNames.TabIndex = 18;
            this.SceneNames.SelectedIndexChanged += new System.EventHandler(this.SceneNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Audio Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Scene Change Events";
            // 
            // SceneChangeDuration
            // 
            this.SceneChangeDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.SceneChangeDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneChangeDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SceneChangeDuration.Location = new System.Drawing.Point(104, 221);
            this.SceneChangeDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SceneChangeDuration.Name = "SceneChangeDuration";
            this.SceneChangeDuration.Size = new System.Drawing.Size(100, 20);
            this.SceneChangeDuration.TabIndex = 24;
            this.SceneChangeDuration.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.SceneChangeDuration.ValueChanged += new System.EventHandler(this.SceneChangeDuration_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Scene Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Seconds";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Silver;
            this.ExitButton.Location = new System.Drawing.Point(1155, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 35);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 780);
            this.panel1.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(13, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(619, 752);
            this.panel6.TabIndex = 31;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.panel8.Controls.Add(this.richTextBox2);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.VideoRewards);
            this.panel8.Controls.Add(this.VideoUrls);
            this.panel8.Controls.Add(this.AddVideoButton);
            this.panel8.Controls.Add(this.DeleteVideoButton);
            this.panel8.Location = new System.Drawing.Point(3, 402);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(316, 347);
            this.panel8.TabIndex = 30;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox2.Location = new System.Drawing.Point(18, 42);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(255, 39);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "Add a video on stream when a reward has been claimed.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Video Events";
            // 
            // VideoRewards
            // 
            this.VideoRewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.VideoRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoRewards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VideoRewards.FormattingEnabled = true;
            this.VideoRewards.Location = new System.Drawing.Point(18, 87);
            this.VideoRewards.Name = "VideoRewards";
            this.VideoRewards.Size = new System.Drawing.Size(137, 93);
            this.VideoRewards.TabIndex = 17;
            // 
            // VideoUrls
            // 
            this.VideoUrls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.VideoUrls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoUrls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VideoUrls.FormattingEnabled = true;
            this.VideoUrls.Location = new System.Drawing.Point(156, 87);
            this.VideoUrls.Name = "VideoUrls";
            this.VideoUrls.Size = new System.Drawing.Size(139, 93);
            this.VideoUrls.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Channel Rewards";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.SceneSourceRewards);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.SceneSourceNames);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.AddSceneSourceButton);
            this.panel5.Controls.Add(this.SceneSourceChangeDuration);
            this.panel5.Controls.Add(this.DeleteSceneSourceButton);
            this.panel5.Location = new System.Drawing.Point(340, 399);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 350);
            this.panel5.TabIndex = 29;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(18, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 39);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "Changes a scene\'s source to visible for a certain duration. Changes back to the o" +
    "ld scene when it ends.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Scene Source Change Events";
            // 
            // SceneSourceRewards
            // 
            this.SceneSourceRewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.SceneSourceRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneSourceRewards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SceneSourceRewards.FormattingEnabled = true;
            this.SceneSourceRewards.Location = new System.Drawing.Point(18, 87);
            this.SceneSourceRewards.Name = "SceneSourceRewards";
            this.SceneSourceRewards.Size = new System.Drawing.Size(120, 93);
            this.SceneSourceRewards.TabIndex = 17;
            this.SceneSourceRewards.SelectedIndexChanged += new System.EventHandler(this.SceneSourceRewards_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(210, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Seconds";
            // 
            // SceneSourceNames
            // 
            this.SceneSourceNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.SceneSourceNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneSourceNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SceneSourceNames.FormattingEnabled = true;
            this.SceneSourceNames.Location = new System.Drawing.Point(139, 87);
            this.SceneSourceNames.Name = "SceneSourceNames";
            this.SceneSourceNames.Size = new System.Drawing.Size(120, 93);
            this.SceneSourceNames.TabIndex = 18;
            this.SceneSourceNames.SelectedIndexChanged += new System.EventHandler(this.SceneSourceNames_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Source Duration";
            // 
            // SceneSourceChangeDuration
            // 
            this.SceneSourceChangeDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.SceneSourceChangeDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneSourceChangeDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SceneSourceChangeDuration.Location = new System.Drawing.Point(104, 221);
            this.SceneSourceChangeDuration.Name = "SceneSourceChangeDuration";
            this.SceneSourceChangeDuration.Size = new System.Drawing.Size(100, 20);
            this.SceneSourceChangeDuration.TabIndex = 24;
            this.SceneSourceChangeDuration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.SceneChangeEventsInfo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SceneRewards);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SceneNames);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.AddSceneButton);
            this.panel3.Controls.Add(this.SceneChangeDuration);
            this.panel3.Controls.Add(this.DeleteSceneButton);
            this.panel3.Location = new System.Drawing.Point(340, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 350);
            this.panel3.TabIndex = 28;
            // 
            // SceneChangeEventsInfo
            // 
            this.SceneChangeEventsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.SceneChangeEventsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SceneChangeEventsInfo.ForeColor = System.Drawing.Color.Silver;
            this.SceneChangeEventsInfo.Location = new System.Drawing.Point(18, 42);
            this.SceneChangeEventsInfo.Name = "SceneChangeEventsInfo";
            this.SceneChangeEventsInfo.Size = new System.Drawing.Size(221, 33);
            this.SceneChangeEventsInfo.TabIndex = 27;
            this.SceneChangeEventsInfo.Text = "Changes scene for a certain duration. Changes back to the old scene when it ends." +
    "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.AudioEventsInfo);
            this.panel2.Controls.Add(this.lstbxSoundsRewards);
            this.panel2.Controls.Add(this.btnEditTitle);
            this.panel2.Controls.Add(this.trkVolume);
            this.panel2.Controls.Add(this.btnStopAll);
            this.panel2.Controls.Add(this.btnEditSound);
            this.panel2.Controls.Add(this.txtVolume);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnTest);
            this.panel2.Controls.Add(this.lblVolume);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblLine);
            this.panel2.Controls.Add(this.lstbxSoundsPaths);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 350);
            this.panel2.TabIndex = 27;
            // 
            // AudioEventsInfo
            // 
            this.AudioEventsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.AudioEventsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AudioEventsInfo.ForeColor = System.Drawing.Color.Silver;
            this.AudioEventsInfo.Location = new System.Drawing.Point(16, 42);
            this.AudioEventsInfo.Name = "AudioEventsInfo";
            this.AudioEventsInfo.Size = new System.Drawing.Size(221, 33);
            this.AudioEventsInfo.TabIndex = 28;
            this.AudioEventsInfo.Text = "Plays an audio when a reward is redeemed.";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.panel7.Controls.Add(this.TTSSettingsButton);
            this.panel7.Controls.Add(this.TTSSettingsPanel);
            this.panel7.Controls.Add(this.TwitchLoginPanel);
            this.panel7.Controls.Add(this.SpeechChatCheckbox);
            this.panel7.Controls.Add(this.ChatTextBox);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(947, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 740);
            this.panel7.TabIndex = 30;
            // 
            // TTSSettingsPanel
            // 
            this.TTSSettingsPanel.Controls.Add(this.label15);
            this.TTSSettingsPanel.Controls.Add(this.TTSSubscribersOnlyCheckbox);
            this.TTSSettingsPanel.Controls.Add(this.label14);
            this.TTSSettingsPanel.Controls.Add(this.SpeechChatComboBox);
            this.TTSSettingsPanel.Location = new System.Drawing.Point(41, 230);
            this.TTSSettingsPanel.Name = "TTSSettingsPanel";
            this.TTSSettingsPanel.Size = new System.Drawing.Size(199, 145);
            this.TTSSettingsPanel.TabIndex = 38;
            this.TTSSettingsPanel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(4, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Voice";
            // 
            // TTSSubscribersOnlyCheckbox
            // 
            this.TTSSubscribersOnlyCheckbox.AutoSize = true;
            this.TTSSubscribersOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TTSSubscribersOnlyCheckbox.ForeColor = System.Drawing.Color.White;
            this.TTSSubscribersOnlyCheckbox.Location = new System.Drawing.Point(7, 93);
            this.TTSSubscribersOnlyCheckbox.Name = "TTSSubscribersOnlyCheckbox";
            this.TTSSubscribersOnlyCheckbox.Size = new System.Drawing.Size(103, 17);
            this.TTSSubscribersOnlyCheckbox.TabIndex = 39;
            this.TTSSubscribersOnlyCheckbox.Text = "Subscribers Only";
            this.TTSSubscribersOnlyCheckbox.UseVisualStyleBackColor = true;
            this.TTSSubscribersOnlyCheckbox.CheckedChanged += new System.EventHandler(this.TTSSubscribersOnlyCheckbox_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "TTS Settings";
            // 
            // SpeechChatComboBox
            // 
            this.SpeechChatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.SpeechChatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeechChatComboBox.ForeColor = System.Drawing.Color.White;
            this.SpeechChatComboBox.FormattingEnabled = true;
            this.SpeechChatComboBox.Location = new System.Drawing.Point(7, 52);
            this.SpeechChatComboBox.Name = "SpeechChatComboBox";
            this.SpeechChatComboBox.Size = new System.Drawing.Size(121, 21);
            this.SpeechChatComboBox.TabIndex = 35;
            this.SpeechChatComboBox.Visible = false;
            this.SpeechChatComboBox.SelectedIndexChanged += new System.EventHandler(this.SpeechChatComboBox_SelectedIndexChanged);
            // 
            // TwitchLoginPanel
            // 
            this.TwitchLoginPanel.Controls.Add(this.TwitchConnectButton);
            this.TwitchLoginPanel.Controls.Add(this.TwitchOAuthInput);
            this.TwitchLoginPanel.Controls.Add(this.label12);
            this.TwitchLoginPanel.Controls.Add(this.TwitchUsernameInput);
            this.TwitchLoginPanel.Controls.Add(this.label11);
            this.TwitchLoginPanel.Location = new System.Drawing.Point(22, 87);
            this.TwitchLoginPanel.Name = "TwitchLoginPanel";
            this.TwitchLoginPanel.Size = new System.Drawing.Size(235, 137);
            this.TwitchLoginPanel.TabIndex = 34;
            // 
            // TwitchOAuthInput
            // 
            this.TwitchOAuthInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.TwitchOAuthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TwitchOAuthInput.ForeColor = System.Drawing.Color.White;
            this.TwitchOAuthInput.Location = new System.Drawing.Point(118, 51);
            this.TwitchOAuthInput.Name = "TwitchOAuthInput";
            this.TwitchOAuthInput.Size = new System.Drawing.Size(100, 20);
            this.TwitchOAuthInput.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Twitch OAuth";
            // 
            // TwitchUsernameInput
            // 
            this.TwitchUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.TwitchUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TwitchUsernameInput.ForeColor = System.Drawing.Color.White;
            this.TwitchUsernameInput.Location = new System.Drawing.Point(118, 15);
            this.TwitchUsernameInput.Name = "TwitchUsernameInput";
            this.TwitchUsernameInput.Size = new System.Drawing.Size(100, 20);
            this.TwitchUsernameInput.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Twitch Username";
            // 
            // SpeechChatCheckbox
            // 
            this.SpeechChatCheckbox.AutoSize = true;
            this.SpeechChatCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpeechChatCheckbox.ForeColor = System.Drawing.Color.White;
            this.SpeechChatCheckbox.Location = new System.Drawing.Point(181, 21);
            this.SpeechChatCheckbox.Name = "SpeechChatCheckbox";
            this.SpeechChatCheckbox.Size = new System.Drawing.Size(45, 17);
            this.SpeechChatCheckbox.TabIndex = 33;
            this.SpeechChatCheckbox.Text = "TTS";
            this.SpeechChatCheckbox.UseVisualStyleBackColor = true;
            this.SpeechChatCheckbox.Visible = false;
            this.SpeechChatCheckbox.CheckedChanged += new System.EventHandler(this.SpeechChatCheckbox_CheckedChanged);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTextBox.ForeColor = System.Drawing.Color.Silver;
            this.ChatTextBox.Location = new System.Drawing.Point(22, 87);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.Size = new System.Drawing.Size(235, 643);
            this.ChatTextBox.TabIndex = 29;
            this.ChatTextBox.Text = "";
            this.ChatTextBox.Visible = false;
            this.ChatTextBox.TextChanged += new System.EventHandler(this.ChatTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Chat";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.LogTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(651, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 740);
            this.panel4.TabIndex = 29;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.ForeColor = System.Drawing.Color.Silver;
            this.LogTextBox.Location = new System.Drawing.Point(22, 87);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(235, 641);
            this.LogTextBox.TabIndex = 29;
            this.LogTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Logs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChannelPointsPlus.Properties.Resources.ChannelRewardsSystem;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(69)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1242, 831);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.btnSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.MinimumSize = new System.Drawing.Size(341, 326);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silverhaze\'s Channel Points";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_OnClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneChangeDuration)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SceneSourceChangeDuration)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.TTSSettingsPanel.ResumeLayout(false);
            this.TTSSettingsPanel.PerformLayout();
            this.TwitchLoginPanel.ResumeLayout(false);
            this.TwitchLoginPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ListBox lstbxSoundsRewards;
        private System.Windows.Forms.ListBox lstbxSoundsPaths;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEditTitle;
        private System.Windows.Forms.Button btnEditSound;
        private System.Windows.Forms.ListBox SceneRewards;
        private System.Windows.Forms.ListBox SceneNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSceneButton;
        private System.Windows.Forms.Button DeleteSceneButton;
        private System.Windows.Forms.NumericUpDown SceneChangeDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox SceneChangeEventsInfo;
        private System.Windows.Forms.RichTextBox AudioEventsInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox SceneSourceRewards;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox SceneSourceNames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddSceneSourceButton;
        private System.Windows.Forms.NumericUpDown SceneSourceChangeDuration;
        private System.Windows.Forms.Button DeleteSceneSourceButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TwitchUsernameInput;
        private System.Windows.Forms.TextBox TwitchOAuthInput;
        private System.Windows.Forms.Button TwitchConnectButton;
        private System.Windows.Forms.CheckBox SpeechChatCheckbox;
        private System.Windows.Forms.Panel TwitchLoginPanel;
        private System.Windows.Forms.ComboBox SpeechChatComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox VideoRewards;
        private System.Windows.Forms.ListBox VideoUrls;
        private System.Windows.Forms.Button AddVideoButton;
        private System.Windows.Forms.Button DeleteVideoButton;
        private System.Windows.Forms.Button TTSSettingsButton;
        private System.Windows.Forms.Panel TTSSettingsPanel;
        private System.Windows.Forms.CheckBox TTSSubscribersOnlyCheckbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
    }
}

