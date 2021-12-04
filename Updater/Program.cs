using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            string version = string.Empty;
            foreach (string arg in args)
            {
                if (arg.StartsWith("--ver"))
                {
                    version = arg.Replace("--ver", "");
                }
            }
            Console.WriteLine("Download new version in proccess...");
            WebClient Client = new WebClient();
            string currentDirectory = Directory.GetCurrentDirectory();
            string tempFileDirectory = currentDirectory + "/temp.zip";
            Client.DownloadFile(string.Format("https://github.com/owoPeef/Sandruve/releases/download/{0}/Sandruve.zip", version), tempFileDirectory);
            ZipArchive zip = ZipFile.OpenRead(tempFileDirectory);
            foreach (ZipArchiveEntry file in zip.Entries)
            {
                File.Delete(string.Format(currentDirectory + "/{0}", file.Name));
            }
            ZipFile.ExtractToDirectory(tempFileDirectory, currentDirectory + "/");
            zip.Dispose();
            File.Delete(tempFileDirectory);
        }
    }
}
