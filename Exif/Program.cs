using SixLabors.ImageSharp;
using System;
using System.IO;

namespace Exif
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream input = File.OpenRead(@"D:\IMG_0827.JPG"))
            {
                var  image =  Image.Load(input);
                var exif = image.MetaData.ExifProfile.Values;
                foreach (var item in exif)
                {
                    Console.WriteLine(item.Tag + ":" + item.Value);
                }
            }
        }
     
    }
}
