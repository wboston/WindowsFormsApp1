using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class GameObjects
    {

    }

    class User : Base
    {

        public void move ()
        {

        }
    }

    abstract class Base
    {
        /// <summary>
        /// General Properties
        /// </summary>
        protected double Height { get; set; }
        protected double Width { get; set; }
        protected Brush Color { get; set; }


        /// <summary>
        /// Coordinates and Movement Speed
        /// </summary>
        protected double X { get; set; }
        protected double Y { get; set; }
        protected double XSpeed { get; set; }
        protected double YSpeed { get; set; }

        Base()
        {
            Height = 5;
            Width = 5;
            Color = Brushes.Red;

            X = 0;
            XSpeed = 1;
            Y = 0;
            XSpeed = 1;
        }
        Base(double height, double width, Brush color)
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
        abstract public bool reset();
        
        


    }
}
