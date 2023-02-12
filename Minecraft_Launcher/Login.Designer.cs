namespace Minecraft_Launcher
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.extra3 = new System.Windows.Forms.Label();
            this.DiscordObject = new FontAwesome.Sharp.IconButton();
            this.extra2 = new System.Windows.Forms.Label();
            this.extra1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.ContinueObject = new FontAwesome.Sharp.IconButton();
            this.backOffObject = new FontAwesome.Sharp.IconButton();
            this.extra4 = new System.Windows.Forms.Label();
            this.txtnameObject = new CustomControls.RJControls.ZDLTextBox();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.helpObject = new System.Windows.Forms.LinkLabel();
            this.OfflineObject = new FontAwesome.Sharp.IconButton();
            this.LoginObject = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panelTitleBar.Controls.Add(this.button2);
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Controls.Add(this.title);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 27);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(953, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "−";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(979, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "⨉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.Color.Gray;
            this.title.Location = new System.Drawing.Point(8, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(198, 15);
            this.title.TabIndex = 0;
            this.title.Text = "Open Launcher [VER] | build [BUILD]";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelContent.Controls.Add(this.extra3);
            this.panelContent.Controls.Add(this.DiscordObject);
            this.panelContent.Controls.Add(this.extra2);
            this.panelContent.Controls.Add(this.extra1);
            this.panelContent.Controls.Add(this.panelRight);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1008, 581);
            this.panelContent.TabIndex = 2;
            // 
            // extra3
            // 
            this.extra3.AutoSize = true;
            this.extra3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra3.ForeColor = System.Drawing.Color.Gray;
            this.extra3.Location = new System.Drawing.Point(820, 402);
            this.extra3.Name = "extra3";
            this.extra3.Size = new System.Drawing.Size(154, 21);
            this.extra3.TabIndex = 6;
            this.extra3.Text = "- Aurora Dev Studios";
            // 
            // DiscordObject
            // 
            this.DiscordObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DiscordObject.FlatAppearance.BorderSize = 0;
            this.DiscordObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiscordObject.ForeColor = System.Drawing.Color.White;
            this.DiscordObject.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.DiscordObject.IconColor = System.Drawing.Color.White;
            this.DiscordObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DiscordObject.IconSize = 32;
            this.DiscordObject.Location = new System.Drawing.Point(525, 330);
            this.DiscordObject.Name = "DiscordObject";
            this.DiscordObject.Size = new System.Drawing.Size(362, 40);
            this.DiscordObject.TabIndex = 5;
            this.DiscordObject.Text = "     Unirse a nuestro servidor de Discord";
            this.DiscordObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiscordObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DiscordObject.UseVisualStyleBackColor = false;
            // 
            // extra2
            // 
            this.extra2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra2.ForeColor = System.Drawing.Color.White;
            this.extra2.Location = new System.Drawing.Point(416, 216);
            this.extra2.Name = "extra2";
            this.extra2.Size = new System.Drawing.Size(558, 99);
            this.extra2.TabIndex = 2;
            this.extra2.Text = "Este software esta en un desarollo constante, por lo tanto, puede estar sujeto a " +
    "cambios.\r\n\r\nAlguna sugerencia, puede ser enviada en nuestro servidor de Discord:" +
    "";
            this.extra2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // extra1
            // 
            this.extra1.AutoSize = true;
            this.extra1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra1.ForeColor = System.Drawing.Color.White;
            this.extra1.Location = new System.Drawing.Point(545, 175);
            this.extra1.Name = "extra1";
            this.extra1.Size = new System.Drawing.Size(303, 30);
            this.extra1.TabIndex = 1;
            this.extra1.Text = "¡Bienvenido a Open Launcher!";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panelRight.Controls.Add(this.ContinueObject);
            this.panelRight.Controls.Add(this.backOffObject);
            this.panelRight.Controls.Add(this.extra4);
            this.panelRight.Controls.Add(this.txtnameObject);
            this.panelRight.Controls.Add(this.titleLogo);
            this.panelRight.Controls.Add(this.helpObject);
            this.panelRight.Controls.Add(this.OfflineObject);
            this.panelRight.Controls.Add(this.LoginObject);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(368, 581);
            this.panelRight.TabIndex = 0;
            // 
            // ContinueObject
            // 
            this.ContinueObject.BackColor = System.Drawing.Color.Turquoise;
            this.ContinueObject.FlatAppearance.BorderSize = 0;
            this.ContinueObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueObject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueObject.ForeColor = System.Drawing.Color.Black;
            this.ContinueObject.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ContinueObject.IconColor = System.Drawing.Color.White;
            this.ContinueObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ContinueObject.IconSize = 32;
            this.ContinueObject.Location = new System.Drawing.Point(278, 414);
            this.ContinueObject.Name = "ContinueObject";
            this.ContinueObject.Size = new System.Drawing.Size(86, 40);
            this.ContinueObject.TabIndex = 9;
            this.ContinueObject.Text = "Continuar";
            this.ContinueObject.UseVisualStyleBackColor = false;
            this.ContinueObject.Visible = false;
            this.ContinueObject.Click += new System.EventHandler(this.ContinueObject_Click);
            // 
            // backOffObject
            // 
            this.backOffObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backOffObject.FlatAppearance.BorderSize = 0;
            this.backOffObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backOffObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backOffObject.ForeColor = System.Drawing.Color.White;
            this.backOffObject.IconChar = FontAwesome.Sharp.IconChar.None;
            this.backOffObject.IconColor = System.Drawing.Color.White;
            this.backOffObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backOffObject.IconSize = 32;
            this.backOffObject.Location = new System.Drawing.Point(3, 414);
            this.backOffObject.Name = "backOffObject";
            this.backOffObject.Size = new System.Drawing.Size(86, 40);
            this.backOffObject.TabIndex = 8;
            this.backOffObject.Text = "Atras";
            this.backOffObject.UseVisualStyleBackColor = false;
            this.backOffObject.Visible = false;
            this.backOffObject.Click += new System.EventHandler(this.backOffObject_Click);
            // 
            // extra4
            // 
            this.extra4.AutoSize = true;
            this.extra4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra4.ForeColor = System.Drawing.Color.White;
            this.extra4.Location = new System.Drawing.Point(117, 238);
            this.extra4.Name = "extra4";
            this.extra4.Size = new System.Drawing.Size(150, 21);
            this.extra4.TabIndex = 7;
            this.extra4.Text = "Nombre de Usuario:";
            this.extra4.Visible = false;
            // 
            // txtnameObject
            // 
            this.txtnameObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.txtnameObject.BorderColor = System.Drawing.Color.Turquoise;
            this.txtnameObject.BorderFocusColor = System.Drawing.Color.LightSeaGreen;
            this.txtnameObject.BorderRadius = 15;
            this.txtnameObject.BorderSize = 2;
            this.txtnameObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnameObject.ForeColor = System.Drawing.Color.White;
            this.txtnameObject.Location = new System.Drawing.Point(2, 376);
            this.txtnameObject.Margin = new System.Windows.Forms.Padding(4);
            this.txtnameObject.Multiline = false;
            this.txtnameObject.Name = "txtnameObject";
            this.txtnameObject.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnameObject.PasswordChar = false;
            this.txtnameObject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnameObject.PlaceholderText = "";
            this.txtnameObject.Size = new System.Drawing.Size(362, 31);
            this.txtnameObject.TabIndex = 7;
            this.txtnameObject.Texts = "";
            this.txtnameObject.UnderlinedStyle = false;
            this.txtnameObject.Visible = false;
            // 
            // titleLogo
            // 
            this.titleLogo.Image = global::Minecraft_Launcher.Properties.Resources.Screen;
            this.titleLogo.Location = new System.Drawing.Point(45, 105);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(278, 50);
            this.titleLogo.TabIndex = 4;
            this.titleLogo.TabStop = false;
            // 
            // helpObject
            // 
            this.helpObject.AutoSize = true;
            this.helpObject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpObject.LinkColor = System.Drawing.Color.Gray;
            this.helpObject.Location = new System.Drawing.Point(117, 552);
            this.helpObject.Name = "helpObject";
            this.helpObject.Size = new System.Drawing.Size(130, 20);
            this.helpObject.TabIndex = 3;
            this.helpObject.TabStop = true;
            this.helpObject.Text = "¿Necesitas ayuda?";
            // 
            // OfflineObject
            // 
            this.OfflineObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OfflineObject.FlatAppearance.BorderSize = 0;
            this.OfflineObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfflineObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OfflineObject.ForeColor = System.Drawing.Color.White;
            this.OfflineObject.IconChar = FontAwesome.Sharp.IconChar.User;
            this.OfflineObject.IconColor = System.Drawing.Color.White;
            this.OfflineObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OfflineObject.IconSize = 32;
            this.OfflineObject.Location = new System.Drawing.Point(3, 308);
            this.OfflineObject.Name = "OfflineObject";
            this.OfflineObject.Size = new System.Drawing.Size(362, 40);
            this.OfflineObject.TabIndex = 2;
            this.OfflineObject.Text = "     Iniciar sesion como invitado";
            this.OfflineObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OfflineObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OfflineObject.UseVisualStyleBackColor = false;
            this.OfflineObject.Click += new System.EventHandler(this.OfflineObject_Click);
            // 
            // LoginObject
            // 
            this.LoginObject.BackColor = System.Drawing.Color.Turquoise;
            this.LoginObject.FlatAppearance.BorderSize = 0;
            this.LoginObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginObject.ForeColor = System.Drawing.Color.Black;
            this.LoginObject.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
            this.LoginObject.IconColor = System.Drawing.Color.Black;
            this.LoginObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoginObject.IconSize = 32;
            this.LoginObject.Location = new System.Drawing.Point(3, 262);
            this.LoginObject.Name = "LoginObject";
            this.LoginObject.Size = new System.Drawing.Size(362, 40);
            this.LoginObject.TabIndex = 0;
            this.LoginObject.Text = "     Iniciar sesion con Microsoft";
            this.LoginObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginObject.UseVisualStyleBackColor = false;
            this.LoginObject.Click += new System.EventHandler(this.LoginObject_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch | Form_A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelContent;
        private Label title;
        private Button button1;
        private Panel panelRight;
        private Button button2;
        private FontAwesome.Sharp.IconButton LoginObject;
        private FontAwesome.Sharp.IconButton OfflineObject;
        private PictureBox titleLogo;
        private LinkLabel helpObject;
        private FontAwesome.Sharp.IconButton DiscordObject;
        private Label extra2;
        private Label extra1;
        private Label extra3;
        private Label extra4;
        private CustomControls.RJControls.ZDLTextBox txtnameObject;
        private FontAwesome.Sharp.IconButton backOffObject;
        private FontAwesome.Sharp.IconButton ContinueObject;
    }
}