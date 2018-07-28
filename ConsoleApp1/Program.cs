using AddonMaster.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
            ExtractToDirectory(@"C:\Users\Oscar\Desktop\1.zip", @"C:\Users\Oscar\Desktop");
        }

        static void ExtractToDirectory(string sourceFileName, string destinationDirectoryName)
        {
            ZipFile.Open(@"C:\Users\Oscar\Desktop\1.zip", ZipArchiveMode.Read).Entries
                                                                              .Select(x => x.FullName.Split('/')
                                                                                                                .First())
                                                                                                                .Distinct()
                                                                                                                           .ToList()
                                                                                                                                    .ForEach(z =>
                                                                                                                                    {
                                                                                                                                        if (Directory.Exists(destinationDirectoryName + @"\" + z))
                                                                                                                                        {
                                                                                                                                            Directory.Delete(destinationDirectoryName + @"\" + z, true);
                                                                                                                                        }
                                                                                                                                    });
            ZipFile.ExtractToDirectory(sourceFileName, destinationDirectoryName);
        }
    }
}
