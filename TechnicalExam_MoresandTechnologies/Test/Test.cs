using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalExam_MoresandTechnologies;

namespace TestApp
{
    internal class Test
    {
        public byte[] Image_To_ByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image Byte_Array_To_Image(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void Test1()
        {
            try
            {
                Class1 classObj = new Class1();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
