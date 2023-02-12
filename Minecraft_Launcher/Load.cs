﻿using DiscordRPC;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Minecraft_Launcher
{
    public partial class Load : Form
    {
        private DiscordRpcClient? client;
        private Size formSize;
        private int borderSize = 2;
        RegistryKey wkey;

        public Load()
        {
            InitializeComponent();
        }

        #region CallDLL = MoveForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }
        #endregion
        private void MoveForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #region AdjustWindows

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion
        #region DiscordConnect

        private void DiscordRPC()
        {
            client = new DiscordRpcClient("1074071966027354214");

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                State = "",
                Details = "Cargando...",
                Assets = new Assets()
                {

                    LargeImageKey = "icondiscord",
                    LargeImageText = "Open Launcher",
                    SmallImageKey = "",
                    SmallImageText = ""

                }
            });
        }

        #endregion
        private void Load_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;

            Text = "Open Launcher " + Application.ProductVersion + " | build f0211btv";

            loadObject.Active = true;
            loadObject.NumberSpoke = 50;
            loadObject.SpokeThickness = 2;
            loadObject.InnerCircleRadius = 10;
            loadObject.OuterCircleRadius = 11;
            loadObject.RotationSpeed = 50;


            DiscordRPC();
            ReadRegistryEntrys();
        }

        #region Load_Activities

        private async Task ReadRegistryEntrys()
        {
            try
            {
                int folders_created = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Checkings", "Folders", null));
                int session_ready = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\User\Session", "Login?", null));
                string minecraft_directory = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Config", "Minecraft_Dir", null) as string;
                string registry_created = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Checkings", "RegistryKeys", null) as string;
                string app_used = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Aurora Studios\Open Launcher\App\Checkings", "Runned", null) as string;

                

            }
            catch (Exception)
            {
                MessageBox.Show("Lectura de registros incorrecta.", ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async Task CreateFolders()
        {

        }

        #endregion

        #region Title Bar Controls
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Anims Btns
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gray;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gray;
        }

        private void repairObject_MouseEnter(object sender, EventArgs e)
        {
            repairObject.IconColor = Color.White;
            extra1.ForeColor = Color.White;
        }

        private void repairObject_MouseLeave(object sender, EventArgs e)
        {
            repairObject.IconColor = Color.Gray;
            extra1.ForeColor = Color.Gray;
        }
        #endregion

        private void repairObject_Click(object sender, EventArgs e)
        {
            Repair r = new Repair();
            client.UpdateDetails("Reparando launcher...");
            r.ShowDialog();
            client.UpdateDetails("Cargando...");
        }
    }
}
