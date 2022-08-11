using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //Single image multi plugins
        public List<Plugin> Test_API(Image image)
        {
            try
            {
                APIClass classObj = new APIClass(new List<Plugin> {
                    new Plugin {
                        Image = image,
                        PluginType=PluginTypes.Resize,
                    },
                    new Plugin {
                        Image = image,
                        PluginType=PluginTypes.Blur,
                    }});
                return classObj.PluginHandler();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message, "Error in Plugin Handler", EventLogEntryType.Error);
                return null;
            }
        }

        //multi image multi plugins
        public List<List<Plugin>> Test_API_MI(List<Image> images)
        {
            List<List<Plugin>> col = new List<List<Plugin>>();
            try
            {
                foreach (var image in images)
                {
                    APIClass classObj = new APIClass(new List<Plugin> {
                    new Plugin {
                        Image = image,
                        PluginType=PluginTypes.Resize,
                    },
                    //Blur feature not working just for demonstrate
                    new Plugin {
                        Image = image,
                        PluginType=PluginTypes.Blur,
                    }});
                    col.Add(classObj.PluginHandler());
                }
                return col;            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message, "Error in Plugin Handler", EventLogEntryType.Error);
                return null;
            }
        }
    }
}
