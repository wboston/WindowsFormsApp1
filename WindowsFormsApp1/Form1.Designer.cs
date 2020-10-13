using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// PictureBox for all game graphics
        /// </summary>
        PictureBox pictureBox1 = new PictureBox();

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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public void Init_PictureBoxAtRuntime()
        {
            pictureBox1.Size = new Size(this.Width, this.Height);
            this.Controls.Add(pictureBox1);

            Graphics GameGraphics = Graphics.FromImage(new Bitmap(this.Width, this.Height)); // init display window


        }



        
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

