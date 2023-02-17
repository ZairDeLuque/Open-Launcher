using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Launcher.Components.TabControls.Instances_subTC.imageListCreate
{
    internal class imageListCreate_Component
    {
        public static ImageList InitImageListFromDirectory(string pDirectory)
        {
            ImageList imageList = new ImageList();

            foreach (string f in Directory.GetFiles(pDirectory))
            {
                try
                {
                    Image img = Image.FromFile(f);
                    imageList.Images.Add(img);
                }
                catch
                {
                    MessageBox.Show("Error en lectura de iconos, compruebe la integridad de los objetos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return imageList;
        }
    }
}
