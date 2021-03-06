using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Sandruve
{
    class Utils
    {
        public static string ReformatString(string str)
        {
            string last = string.Empty;
            if (str.EndsWith(""))
            {
                last = str.Replace("\u0013", string.Empty);
            }
            return last;
        }

        public static byte[] GetBytesFromFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        public static string GetMimeTypeFromImageByteArray(byte[] byteArray)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(byteArray))
                using (Image image = Image.FromStream(stream))
                {
                    return ImageCodecInfo.GetImageEncoders().First(codec => codec.FormatID == image.RawFormat.Guid).MimeType;
                }
            }
            catch
            {
                return null;
            }
        }

        public static JArray ParseURL(string urlToParse)
        {
            var client = new WebClient();
            client.Headers.Add("User-Agent", "Sandruve");
            string content = client.DownloadString(urlToParse);
            return JArray.Parse(content);
        }
    }
}
