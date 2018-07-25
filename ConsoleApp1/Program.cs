using AddonMaster.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        private static Regex downloadImageRegex = new Regex("<meta property=\"og:image\" content=(.*[\\.png|\\.jpg])\"");
        private static Regex donwloadDescriptionRegex = new Regex("<meta name=\"description\" content=(.*)\"");
        private static Regex downloadPatch = new Regex("Game Version: (.*)<");
        private static Regex nameRegex = new Regex("<meta property=\"og:title\" content=\"(.*)\"");

        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                var htmlSource = client.DownloadString("https://www.curseforge.com/wow/addons/deadly-boss-mods");

                var name = downloadImageRegex.Match(htmlSource).Groups[1].Value.Trim(new char[] { '\\', '\"' });
            }
        }
    }
}
