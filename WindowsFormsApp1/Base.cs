using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    abstract class Base
    {
        /// <summary>
        /// General Properties
        /// </summary>
        protected int Height { get; set; }
        protected int Width { get; set; }
        protected Brush Color { get; set; }


        /// <summary>
        /// Coordinates and Movement Speed
        /// </summary>
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int XSpeed { get; set; }
        protected int YSpeed { get; set; }
        public int IsMovingX { get; set; }
        public int IsMovingY { get; set; }

        public Base()
        {
            Height = 5;
            Width = 5;
            Color = Brushes.Red;

            X = 0;
            XSpeed = 1;
            IsMovingX = 0;
            Y = 0;
            XSpeed = 1;
            IsMovingY = 0;
        }

        public Base(int height, int width, Brush color)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        public void Init(int x_pos, int y_pos, int x_speed, int y_speed)
        {
            X = 0;
            XSpeed = 1;
            Y = 0;
            XSpeed = 1;

        }

        /// <summary>
        /// Abstract Member functions for controlling the object
        /// </summary>
        abstract public void MoveX(int x);//movement is multiplied by int to get up down left right movemet
        abstract public void MoveY(int y);

        abstract public bool StopMoveX(int x);
        abstract public bool StopMoveY(int y);

        //abstract class that needs to be set
        abstract public bool Reset();




    }
}
