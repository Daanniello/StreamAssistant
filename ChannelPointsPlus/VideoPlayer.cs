using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class VideoPlayer
    {
        private frmMain _mainForm;
        private string[] prefixes = new string[] { "http://localhost:8000/" };
        public VideoPlayer(frmMain mainForm)
        {
            _mainForm = mainForm;
            // Adds the scenes from settings at start 
            if (File.Exists("settingsVideo.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsVideo.txt");
                foreach (string line in loadSettings)
                {
                    string[] split = line.Split('|');
                    mainForm.bindingsVideo.Add(split[0], split[1]);
                }
            }        
        }

        public void StartHttpListener(string youtubeUrl)
        {
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
                return;
            }
            // URI prefixes are required,
            // for example "http://contoso.com:8080/index/".
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // Create a listener.
            HttpListener listener = new HttpListener();
            // Add the prefixes.
            foreach (string s in prefixes)
            {
                listener.Prefixes.Add(s);
            }
            listener.Start();
            Console.WriteLine("Listening...");
            // Note: The GetContext method blocks while waiting for a request.
            HttpListenerContext context = listener.GetContext();
            HttpListenerRequest request = context.Request;
            // Obtain a response object.
            HttpListenerResponse response = context.Response;
            // Construct a response.
            string responseString = $"<HTML><BODY> <iframe width='560' height='315' src='{youtubeUrl}?autoplay=1&controls=0'</iframe></BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            // Get a response stream and write the response to it.
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            // You must close the output stream.
            output.Close();
            listener.Stop();
        }
    }
}
