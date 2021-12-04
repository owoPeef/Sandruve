using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;

namespace Updater
{
    class Program
    {
        static int msTime = 0;
        static void Main(string[] args)
        {
            Thread a = new Thread(() => {
                while (true)
                {
                    msTime++;
                    Thread.Sleep(1);
                }
            });
            a.Start();
            string version = string.Empty;
            foreach (string arg in args)
            {
                if (arg.StartsWith("--ver"))
                {
                    version = arg.Replace("--ver", "");
                }
            }
            Console.WriteLine("Загрузка новой версии в процессе...");
            WebClient Client = new WebClient();
            string currentDirectory = Directory.GetCurrentDirectory();
            string tempFileDirectory = currentDirectory + "/temp.zip";
            try
            {
                Client.DownloadFile(string.Format("https://github.com/owoPeef/Sandruve/releases/download/{0}/Sandruve.zip", version), tempFileDirectory);
                Console.WriteLine("Файлы новой версии загружены, идёт распаковка архива...");
                ZipArchive zip = ZipFile.OpenRead(tempFileDirectory);
                foreach (ZipArchiveEntry file in zip.Entries)
                {
                    Console.WriteLine("Файл {0} удалён.", file.Name);
                    File.Delete(string.Format(currentDirectory + "/{0}", file.Name));
                }
                ZipFile.ExtractToDirectory(tempFileDirectory, currentDirectory + "/");
                Console.WriteLine("Файл разархивирован, идёт удаление временных файлов...");
                zip.Dispose();
                File.Delete(tempFileDirectory);
                Console.WriteLine("Временные файлы удалены.");
                Console.WriteLine("Установка была завершена за {0}ms.", msTime);
                Process.Start(currentDirectory + "/Sandruve.exe");
                Process.GetCurrentProcess().Kill();
            }
            catch (WebException exc)
            {
                if (exc.Message == "The remote server returned an error: (404) Not Found.")
                {
                    Console.WriteLine("Тег версии не был найден на Github, операция отменена.");
                }
            }
        }
    }
}
