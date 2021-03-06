﻿using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            CreateBitmapAtRuntime();

        }

        #endregion



        PictureBox pictureBox1 = new PictureBox();
        public void CreateBitmapAtRuntime()
        {
            pictureBox1.Size = new Size(this.Width, this.Height);


            this.Controls.Add(pictureBox1);

            Bitmap flag = new Bitmap(this.Width, this.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            int red = 0;
            int white = 11;
            while (white <= this.Height)
            {
                flagGraphics.FillRectangle(Brushes.Red, 0, red, this.Width, 10);
                flagGraphics.FillRectangle(Brushes.White, 0, white, this.Width, 10);
                red += 20;
                white += 20;
            }
            pictureBox1.Image = flag;
        }
    }
}

