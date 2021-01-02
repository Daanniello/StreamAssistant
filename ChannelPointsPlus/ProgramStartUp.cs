using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class ProgramStartUp
    {
        public ProgramStartUp()
        {          
        }

        public static void StartAllPrograms()
        {
            if (File.Exists("settingsStartUpPrograms.txt"))
            {
                String[] startUpSettings = File.ReadAllLines("settingsStartUpPrograms.txt");
                foreach (string line in startUpSettings)
                {
                    var items = line.Split('|');
                    Process.Start($"{items[0]}");
                }
            }
        }
    }
}
