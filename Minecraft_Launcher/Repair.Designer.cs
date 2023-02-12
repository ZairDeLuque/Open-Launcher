namespace Minecraft_Launcher
{
    partial class Repair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair));
            this.ContinueObject = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinueObject
            // 
            this.ContinueObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContinueObject.BackColor = System.Drawing.Color.Turquoise;
            this.ContinueObject.FlatAppearance.BorderSize = 0;
            this.ContinueObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueObject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueObject.ForeColor = System.Drawing.Color.Black;
            this.ContinueObject.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ContinueObject.IconColor = System.Drawing.Color.White;
            this.ContinueObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ContinueObject.IconSize = 32;
            this.ContinueObject.Location = new System.Drawing.Point(243, 122);
            this.ContinueObject.Name = "ContinueObject";
            this.ContinueObject.Size = new System.Drawing.Size(154, 28);
            this.ContinueObject.TabIndex = 17;
            this.ContinueObject.Text = "Continuar";
            this.ContinueObject.UseVisualStyleBackColor = false;
            this.ContinueObject.Click += new System.EventHandler(this.ContinueObject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Minecraft_Launcher.Properties.Resources.warning_logo;
            this.pictureBox1.Location = new System.Drawing.Point(51, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(105, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "¿Estás seguro de reparar todos los registros, componentes y sesiones de la aplica" +
    "ción? Puede significar la perdida TOTAL de algunos archivos.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(549, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 14;
            this.button1.Text = "⨉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // titleLogo
            // 
            this.titleLogo.Image = global::Minecraft_Launcher.Properties.Resources.Screen;
            this.titleLogo.Location = new System.Drawing.Point(12, 12);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(139, 25);
            this.titleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleLogo.TabIndex = 13;
            this.titleLogo.TabStop = false;
            this.titleLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(581, 194);
            this.Controls.Add(this.ContinueObject);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Repair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch | Repair";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ContinueObject;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private PictureBox titleLogo;
    }
}