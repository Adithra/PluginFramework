using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalExam_MoresandTechnologies.Model;

namespace TechnicalExam_MoresandTechnologies
{
    /// <summary>This is the entry point of the Point class testing program.
    /// <para>
    /// This Class provide get list of active plugins and apply plugins setting to images.
    /// To apply plugins setting to images need to pass list of plugin to constructor
    /// </para>
    /// </summary>
    public class APIClass
    {
        List<Plugin> _plugins;

        public APIClass(List<Plugin> plugins = null)
        {
            _plugins = plugins;
        }

        private bool ValidatePlugin(Plugin plugin)
        {
            try
            {
                int[] activePlugins = Get_Active_Plugins();

                if (activePlugins.Contains(((int)plugin.PluginType)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #region External Usage
        /// <summary>
        /// Method <c>Get_Active_Plugins</c> can use to get active plugins list.
        /// </summary>
        /// <returns>
        /// A list of active plugins.
        /// </returns>
        public int[] Get_Active_Plugins()
        {
            string[] activePlugins = Properties.Settings.Default.ActivePlugins.Split(',');
            int[] intArray = Array.ConvertAll(activePlugins, int.Parse);
            return intArray;
        }

        /// <summary>
        /// Method <c>PluginHandler</c> provide apply plugins setting to images.
        /// </summary>
        /// <returns>
        /// A list of Plugin as a result.
        /// </returns>
        public List<Plugin> PluginHandler()
        {
            try
            {
                if (_plugins != null)
                {
                    foreach (var plugin in _plugins)
                    {
                        if (ValidatePlugin(plugin))
                        {
                            if (plugin.PluginType == PluginTypes.Effect1)
                            {
                                //Do chages to plugin.Image
                            }
                            else if (plugin.PluginType == PluginTypes.Effect2)
                            {
                                //Do chages to plugin.Image
                            }
                            else if (plugin.PluginType == PluginTypes.Effect3)
                            {
                                //Do chages to plugin.Image
                            }
                            else if (plugin.PluginType == PluginTypes.Resize)
                            {
                                //Eg:
                                Bitmap b = new Bitmap(plugin.Image.Width * 2, plugin.Image.Height * 2);
                                Graphics g = Graphics.FromImage((System.Drawing.Image)b);
                                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                g.DrawImage(plugin.Image, 0, 0, plugin.Image.Width, plugin.Image.Height);
                                g.Dispose();
                                plugin.Image = (Image)b;
                            }
                            else if (plugin.PluginType == PluginTypes.Blur)
                            {
                                //Do chages to plugin.Image
                            }
                            else if (plugin.PluginType == PluginTypes.ToGrayscale)
                            {
                                //Do chages to plugin.Image
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return _plugins;
        }
        #endregion
    }
}
