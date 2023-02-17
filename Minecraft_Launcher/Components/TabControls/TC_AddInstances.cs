using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft_Launcher.Components.TabControls.Instances_subTC.IconsComponent;

namespace Minecraft_Launcher.Components.TabControls
{
    public partial class TC_AddInstances : UserControl
    {
        public TC_AddInstances()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(43, 48, 53);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(33, 37, 41);
        }

        private void zdlTextBox2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.InitialDirectory = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Config", "Minecraft_Dir", null) as string;
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                zdlTextBox2.Texts = f.SelectedPath;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.InitialDirectory = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Config", "Minecraft_Dir", null) as string;

            if (f.ShowDialog() == DialogResult.OK)
            {
                zdlTextBox2.Texts = f.SelectedPath;
            }
        }

        private void TC_AddInstances_Load(object sender, EventArgs e)
        {
            zdlTextBox2.Texts = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Config", "Minecraft_Dir", null) as string;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult r = Icons_Read_Component.Show();

            if (r == DialogResult.OK)
            {
                MessageBox.Show("Listo");
            }
        }
    }
}
