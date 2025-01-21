using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.IO;

namespace Utils
{
    public class ImageUtils
    {
        public static Image GetImageFromUrl(string url)
        {
            Image img = null;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (Stream stream = webClient.OpenRead(url))
                    {
                        img = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return img;
        }

        public static Image GetImageFromDataBase(object image)
        {
            ImageConverter imageConverter = new ImageConverter();
            Image img;
            try
            {
                if (image == null)
                {
                    img = GetImageFromRelativePath("./login.png");
                }
                else
                {
                    img = (Image)imageConverter.ConvertFrom(image);
                }
                return img;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Image GetImageFromRelativePath(string path)
        {            
            try
            {
                return Image.FromFile(System.IO.Path.Combine(Environment.CurrentDirectory, @path));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
