using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static Regex downloadImageRegex = new Regex("<meta property=\"og:image\" content=(.*\\.png)");
        private static Regex donwloadDescriptionRegex = new Regex("<meta name=\"description\" content=(.*)\"");
        private static Regex downloadPatch = new Regex("Game Version: (.*)<");

        static void Main(string[] args)
        {
            int x = 999999999;

            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                var guid = Guid.NewGuid();
                //client.DownloadFile("https://www.curseforge.com/wow/addons/bartender4/download", @"C:\Users\Oscar Rosner\Desktop\from\");

                var htmlSource = client.DownloadString("https://www.curseforge.com/wow/addons/bartender4/download");

                var imgurl = downloadPatch.Match(htmlSource).Groups[1].Value.Trim(new char[] { '\\', '\"' });
                //client.DownloadFile(donwloadDescriptionRegex.Match(htmlSource).Groups[1].Value, @"C:\Users\Oscar Rosner\Desktop\1.png");
            }
        }
    }
}
