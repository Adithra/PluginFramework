using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TechnicalExam_MoresandTechnologies.Model
{
    public enum PluginTypes
    {
        Effect1,
        Effect2,
        Effect3,
        Resize,
        Blur,
        ToGrayscale
    }         

    public class Plugin
    {
        public int PluginID { get; set; }

        public PluginTypes PluginType { get; set; }

        public Image Image { get; set; }

        public decimal Size { get; set; }

        public decimal Radious { get; set; }

        public bool State { get; set; }
    }
}
