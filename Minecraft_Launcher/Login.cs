using DiscordRPC;
using System.Runtime.InteropServices;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft.UI.WinForm;
using Microsoft.Win32;
using ZairDeLuqueContent.Base64EncoderAndDecoder;


namespace Minecraft_Launcher
{
    public partial class Login : Form
    {
        private Size formSize;
        private int borderSize = 2;
        public DiscordRpcClient? client;
        MSession? Session;
        RegistryKey? wkey;
        private int old_location_txtX, old_back_pointX, old_location_txtY, old_back_pointY, old_location_contX, old_location_contY;

        public Login()
        {
            InitializeComponent();
            Padding = new Padding(1);
            BackColor = Color.FromArgb(43, 48, 53);
        }

        #region Anims_Buttons

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gray;
        }

        #endregion
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
                Details = "Iniciando sesion...",
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

        private void MoveForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;

            title.Text = "Open Launcher " + Application.ProductVersion + " | build f0211btv";
            this.Text = title.Text;

            DiscordRPC();
        }

        #region Title Bar Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region MinecraftAccounts

        private async void MicrosoftLogin()
        {
            if (Session == null)
            {
                try
                {
                    MicrosoftLoginForm f = new MicrosoftLoginForm();
                    f.LoadingText = "Conectando al servidor...";
                    f.Icon = ActiveForm.Icon;
                    f.Text = "Open Launcher | Microsoft Connection";
                    MSession session = await f.ShowLoginDialog();

                    this.Session = session;
                    if (session != null)
                    {

                        wkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Aurora Studios\Open Launcher\App\User\Session", true);
                        wkey.SetValue("UUID", base64.Encoder(session.UUID));
                        wkey.SetValue("Username", base64.Encoder(session.Username));
                        wkey.SetValue("Login?", "1", RegistryValueKind.DWord);

                    }
                    else
                    {
                        MessageBox.Show("Al parecer la sesion actual ha sido irrumpida o creada de forma nula, por lo tanto, pedimos repetir el proceso.", ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Al parecer la sesion actual ha sido irrumpida o creada de forma nula, por lo tanto, pedimos repetir el proceso.", ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginObject_Click(object sender, EventArgs e)
        {
            client.UpdateState("Conectando con Microsoft...");
            MicrosoftLogin();
            client.UpdateState("");
        }

        private void backOffObject_Click(object sender, EventArgs e)
        {
            txtnameObject.Location = new Point(old_location_txtX, old_location_txtY);
            backOffObject.Location = new Point(old_back_pointX, old_back_pointY);
            ContinueObject.Location = new Point(old_location_contX, old_location_contY);


            txtnameObject.Visible = false;
            backOffObject.Visible = false;
            extra4.Visible = false;
            ContinueObject.Visible = false;


            OfflineObject.Visible = true;
            LoginObject.Visible = true;
        }

        private void ContinueObject_Click(object sender, EventArgs e)
        {
            MSession session = MSession.GetOfflineSession(txtnameObject.Texts);
            
            this.Session = session;
           
            Init i = new Init(this.Session);
            i.Show();
            ActiveForm.Close();

        }

        private void OfflineObject_Click(object sender, EventArgs e)
        {
            //New Locations
            old_location_txtX = txtnameObject.Location.X;
            old_location_txtY = txtnameObject.Location.Y;
            old_back_pointX = backOffObject.Location.X;
            old_back_pointY = backOffObject.Location.Y;
            old_location_contX = ContinueObject.Location.X;
            old_location_contY = ContinueObject.Location.Y;


            txtnameObject.Location = new Point(2, 272);
            backOffObject.Location = new Point(2, 318);
            ContinueObject.Location = new Point(278, 318);

            txtnameObject.Visible = true;
            backOffObject.Visible = true;
            extra4.Visible = true;
            ContinueObject.Visible = true;

            OfflineObject.Visible = false;
            LoginObject.Visible = false;
        }

        #endregion


    }
}