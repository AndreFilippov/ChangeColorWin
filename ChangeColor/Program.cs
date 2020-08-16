using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChangeColor());
        }
        
        public static void changeColorPhoto(Color color_1, Color color_2, string[] photos, string path)
        {
            try
            {
                foreach (var photo in photos)
                {
                    Bitmap newImage = new Bitmap(photo, true);

                    newImage = ChangeColor(newImage, color_1, color_2);
                    int index = 1;
                    bool file_no_unique;
                    string newImagePath = $@"{path}/{Path.GetFileNameWithoutExtension(photo)}_changeColor{Path.GetExtension(photo)}";
                    do
                    {
                        newImagePath = $@"{path}/{Path.GetFileNameWithoutExtension(photo)}_{index}{Path.GetExtension(photo)}";
                        file_no_unique = File.Exists(newImagePath);
                        index++;
                    } while (file_no_unique);
                    newImage.Save(newImagePath);
                }

                MessageBox.Show("Успешно изменено");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Возникла ошибка: {e}");
                throw;
            }
        }

        static Bitmap ChangeColor(Bitmap image, Color color_1, Color color_2)
        {
            for (var x = 0; x < image.Width; x++)
            for (var y = 0; y < image.Height; y++)
            {
                var pixel = image.GetPixel(x, y);
                if (pixel.R >= color_1.R - 10 && pixel.R <= color_1.R + 10 && pixel.G >= color_1.G - 10 && pixel.G <= color_1.G + 10 &&
                    pixel.B >= color_1.B - 10 && pixel.B <= color_1.B + 10)
                    image.SetPixel(x, y, color_2);
            }
            return image;
        }
    }
}