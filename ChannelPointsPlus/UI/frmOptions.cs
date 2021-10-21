using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelPointsPlus
{

    public delegate void ReenableSettingsButton();
    public partial class frmOptions : Form
    {
        public event ReenableSettingsButton enSetBut;

        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            cbTrayMini.Checked = Properties.Settings.Default.minimizeToTray;
            string ver = typeof(frmOptions).Assembly.GetName().Version.ToString();
        }

        private void btnResetID_Click(object sender, EventArgs e)
        {
            string userInput = Prompt.ShowDialog("Please enter your Twitch ChannelID. (THIS IS NOT YOUR USERNAME)", "Enter Channel ID");
            if (userInput == "") return;
            Properties.Settings.Default.savedChannelID = userInput;
            Properties.Settings.Default.Save();
            MessageBox.Show("Please restart the program to connect to the new ChannelID.", "StreamAssistant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (enSetBut != null)
            {
                enSetBut();
            }
            this.Close();
            this.Dispose();
        }

        private void cbTrayMini_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minimizeToTray = cbTrayMini.Checked;
            Properties.Settings.Default.Save();
        }

        private void ResetTwitchLoginButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("settingsTwitch.txt"))
            {
                File.Delete("settingsTwitch.txt");
            }

            MessageBox.Show("Please restart the program to connect to the new Twitch login.", "StreamAssistant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
