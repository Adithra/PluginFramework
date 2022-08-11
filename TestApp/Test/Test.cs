using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalExam_MoresandTechnologies;
using TechnicalExam_MoresandTechnologies.Model;

namespace TestApp
{
    internal class Test
    {
        public Image Byte_Array_To_Image(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public List<Plugin> Test_API()
        {
            try
            {
                APIClass classObj = new APIClass(new List<Plugin> {
                    new Plugin {
                        Image = Byte_Array_To_Image(File.ReadAllBytes(@"../../Test/Test.txt")),
                        PluginType=PluginTypes.Resize,
                    },
                    new Plugin {
                        Image = Byte_Array_To_Image(File.ReadAllBytes(@"../../Test/Test.txt")),
                        PluginType=PluginTypes.Resize,
                    }});
                return classObj.PluginHandler();
            }
            catch (Exception)
            {
                return  null;
            }
        }
    }
}
