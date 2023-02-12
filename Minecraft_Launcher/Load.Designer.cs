﻿namespace Minecraft_Launcher
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadObject = new MRG.Controls.UI.LoadingCircle();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLogo
            // 
            this.titleLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLogo.Image = global::Minecraft_Launcher.Properties.Resources.Screen;
            this.titleLogo.Location = new System.Drawing.Point(105, 32);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(278, 50);
            this.titleLogo.TabIndex = 5;
            this.titleLogo.TabStop = false;
            this.titleLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(462, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "⨉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadObject
            // 
            this.loadObject.Active = false;
            this.loadObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loadObject.Color = System.Drawing.Color.LightSeaGreen;
            this.loadObject.InnerCircleRadius = 5;
            this.loadObject.Location = new System.Drawing.Point(225, 83);
            this.loadObject.Name = "loadObject";
            this.loadObject.NumberSpoke = 12;
            this.loadObject.OuterCircleRadius = 11;
            this.loadObject.RotationSpeed = 50;
            this.loadObject.Size = new System.Drawing.Size(39, 41);
            this.loadObject.SpokeThickness = 2;
            this.loadObject.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.loadObject.TabIndex = 7;
            this.loadObject.Text = "loadingCircle1";
            this.loadObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(436, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 22);
            this.button3.TabIndex = 8;
            this.button3.Text = "−";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(489, 141);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.loadObject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.Load += new System.EventHandler(this.Load_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox titleLogo;
        private Button button1;
        private MRG.Controls.UI.LoadingCircle loadObject;
        private Button button3;
    }
}