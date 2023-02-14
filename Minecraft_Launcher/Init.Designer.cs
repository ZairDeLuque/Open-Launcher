namespace Minecraft_Launcher
{
    partial class Init
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.title = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.addinstanceObject = new FontAwesome.Sharp.IconButton();
            this.settingsObject = new FontAwesome.Sharp.IconButton();
            this.changeuObject = new FontAwesome.Sharp.IconButton();
            this.usernameID = new System.Windows.Forms.Label();
            this.cubeFaceObject = new System.Windows.Forms.PictureBox();
            this.extra1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubeFaceObject)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.Color.Gray;
            this.title.Location = new System.Drawing.Point(8, -31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(198, 15);
            this.title.TabIndex = 0;
            this.title.Text = "Open Launcher [VER] | build [BUILD]";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panelTitleBar.Controls.Add(this.titleLogo);
            this.panelTitleBar.Controls.Add(this.button3);
            this.panelTitleBar.Controls.Add(this.button4);
            this.panelTitleBar.Controls.Add(this.button2);
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Controls.Add(this.title);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 27);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // titleLogo
            // 
            this.titleLogo.Image = global::Minecraft_Launcher.Properties.Resources.Screen;
            this.titleLogo.Location = new System.Drawing.Point(1, 1);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(139, 25);
            this.titleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleLogo.TabIndex = 8;
            this.titleLogo.TabStop = false;
            this.titleLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(954, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "−";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gray;
            this.button4.Location = new System.Drawing.Point(980, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 22);
            this.button4.TabIndex = 4;
            this.button4.Text = "⨉";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(1761, -35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "−";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(1787, -35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "⨉";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panelRight.Controls.Add(this.addinstanceObject);
            this.panelRight.Controls.Add(this.settingsObject);
            this.panelRight.Controls.Add(this.changeuObject);
            this.panelRight.Controls.Add(this.usernameID);
            this.panelRight.Controls.Add(this.cubeFaceObject);
            this.panelRight.Controls.Add(this.extra1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(0, 27);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(244, 554);
            this.panelRight.TabIndex = 2;
            // 
            // addinstanceObject
            // 
            this.addinstanceObject.FlatAppearance.BorderSize = 0;
            this.addinstanceObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.addinstanceObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.addinstanceObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addinstanceObject.ForeColor = System.Drawing.Color.White;
            this.addinstanceObject.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addinstanceObject.IconColor = System.Drawing.Color.White;
            this.addinstanceObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addinstanceObject.IconSize = 24;
            this.addinstanceObject.Location = new System.Drawing.Point(-1, 157);
            this.addinstanceObject.Name = "addinstanceObject";
            this.addinstanceObject.Size = new System.Drawing.Size(244, 33);
            this.addinstanceObject.TabIndex = 5;
            this.addinstanceObject.Text = "               Añadir instancia";
            this.addinstanceObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addinstanceObject.UseVisualStyleBackColor = true;
            this.addinstanceObject.Click += new System.EventHandler(this.addinstanceObject_Click);
            // 
            // settingsObject
            // 
            this.settingsObject.FlatAppearance.BorderSize = 0;
            this.settingsObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.settingsObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.settingsObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsObject.ForeColor = System.Drawing.Color.White;
            this.settingsObject.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.settingsObject.IconColor = System.Drawing.Color.White;
            this.settingsObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsObject.IconSize = 24;
            this.settingsObject.Location = new System.Drawing.Point(-1, 118);
            this.settingsObject.Name = "settingsObject";
            this.settingsObject.Size = new System.Drawing.Size(244, 33);
            this.settingsObject.TabIndex = 4;
            this.settingsObject.Text = "           Ajustes del launcher";
            this.settingsObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsObject.UseVisualStyleBackColor = true;
            // 
            // changeuObject
            // 
            this.changeuObject.FlatAppearance.BorderSize = 0;
            this.changeuObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.changeuObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.changeuObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeuObject.ForeColor = System.Drawing.Color.White;
            this.changeuObject.IconChar = FontAwesome.Sharp.IconChar.User;
            this.changeuObject.IconColor = System.Drawing.Color.White;
            this.changeuObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeuObject.IconSize = 24;
            this.changeuObject.Location = new System.Drawing.Point(0, 79);
            this.changeuObject.Name = "changeuObject";
            this.changeuObject.Size = new System.Drawing.Size(244, 33);
            this.changeuObject.TabIndex = 3;
            this.changeuObject.Text = "            Gestión de usuarios";
            this.changeuObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeuObject.UseVisualStyleBackColor = true;
            // 
            // usernameID
            // 
            this.usernameID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameID.ForeColor = System.Drawing.Color.Silver;
            this.usernameID.Location = new System.Drawing.Point(72, 29);
            this.usernameID.Name = "usernameID";
            this.usernameID.Size = new System.Drawing.Size(143, 23);
            this.usernameID.TabIndex = 2;
            this.usernameID.Text = "[NAME]";
            // 
            // cubeFaceObject
            // 
            this.cubeFaceObject.Location = new System.Drawing.Point(18, 6);
            this.cubeFaceObject.Name = "cubeFaceObject";
            this.cubeFaceObject.Size = new System.Drawing.Size(48, 48);
            this.cubeFaceObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cubeFaceObject.TabIndex = 1;
            this.cubeFaceObject.TabStop = false;
            // 
            // extra1
            // 
            this.extra1.AutoSize = true;
            this.extra1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra1.ForeColor = System.Drawing.Color.Silver;
            this.extra1.Location = new System.Drawing.Point(72, 6);
            this.extra1.Name = "extra1";
            this.extra1.Size = new System.Drawing.Size(130, 21);
            this.extra1.TabIndex = 0;
            this.extra1.Text = "Conectado como:";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(244, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(764, 554);
            this.panelContent.TabIndex = 3;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch | Form_B";
            this.Load += new System.EventHandler(this.Init_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubeFaceObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label title;
        private Panel panelTitleBar;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Panel panelRight;
        private Panel panelContent;
        private Label usernameID;
        private PictureBox cubeFaceObject;
        private Label extra1;
        private PictureBox titleLogo;
        private FontAwesome.Sharp.IconButton changeuObject;
        private FontAwesome.Sharp.IconButton addinstanceObject;
        private FontAwesome.Sharp.IconButton settingsObject;
    }
}