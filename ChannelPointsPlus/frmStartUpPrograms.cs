using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelPointsPlus
{
    public partial class frmStartUpPrograms : Form
    {
        public frmStartUpPrograms()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    var name = openFileDialog.SafeFileName;
                    File.AppendAllText("settingsStartUpPrograms.txt", filePath + "|" + name + "\n");
                }
            }

            ReloadProgramsList();
        }

        private void StartUpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProgramStartUp.StartAllPrograms();
        }

        private void frmStartUpPrograms_Load(object sender, EventArgs e)
        {
            ReloadProgramsList();
        }

        private void ReloadProgramsList()
        {
            StartUpListBox.Items.Clear();
            if (File.Exists("settingsStartUpPrograms.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsStartUpPrograms.txt");
                foreach (string line in loadSettings)
                {
                    string[] split = line.Split('|');
                    StartUpListBox.Items.Add(split[1]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("settingsStartUpPrograms.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsStartUpPrograms.txt");
                for(var x = 0; x < loadSettings.Length; x++)
                {
                    var name = loadSettings[x].Split('|')[1];
                    string selectedName = StartUpListBox.Items[StartUpListBox.SelectedIndex] as string;
                    if (name == selectedName)
                    {
                        loadSettings[x] = null;
                    }
                }


                File.WriteAllLines("settingsStartUpPrograms.txt", loadSettings.Where(x => x != null));
            }

            ReloadProgramsList();
        }
    }
}
