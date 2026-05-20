using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI_PhoneStore
{
    public static class ImageHelper
    {
        public static string ImagesFolder
        {
            get
            {
                string folder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                return folder;
            }
        }

        public static string CopyProductImage(string sourcePath)
        {
            if (string.IsNullOrWhiteSpace(sourcePath) || !File.Exists(sourcePath)) return "";
            string fileName = "product_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(sourcePath);
            string dest = Path.Combine(ImagesFolder, fileName);
            File.Copy(sourcePath, dest, true);
            return fileName;
        }

        public static void LoadToPictureBox(PictureBox pic, string fileName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fileName)) { pic.Image = null; return; }
                string path = Path.IsPathRooted(fileName) ? fileName : Path.Combine(ImagesFolder, fileName);
                if (!File.Exists(path)) { pic.Image = null; return; }
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Image img = Image.FromStream(fs);
                    pic.Image = new Bitmap(img);
                }
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                pic.Image = null;
            }
        }
    }
}
