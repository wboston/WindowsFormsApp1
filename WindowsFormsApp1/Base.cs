﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    abstract class Base
    {
        /// <summary>
        /// Object height dimension
        /// </summary>
        protected int Height { get; set; }

        /// <summary>
        /// Object width dimension
        /// </summary>
        protected int Width { get; set; }

        /// <summary>
        /// Object color
        /// </summary>
        protected Brush Color { get; set; }


        /// <summary>
        /// Objects X position
        /// </summary>
        private int X { get; set; }

        /// <summary>
        /// Objects Y position
        /// </summary>
        private int Y { get; set; }

        /// <summary>
        /// Objects X azis movement speed
        /// </summary>
        private int XSpeed { get; set; }

        /// <summary>
        /// Object Y axis movement speed
        /// </summary>
        private int YSpeed { get; set; }

        /// <summary>
        /// Used to tell if the Object is moving by using -1,0,1 
        /// </summary>
        public int MovingX { get; set; }

        /// <summary>
        /// Used to tell if the Object is moving by using -1,0,1 
        /// </summary>
        public int MovingY { get; set; }

        /// <summary>
        /// Base class default constructor
        /// Initializes size to 5x5 red square
        /// Position set to  0,0 with speed of 1,1 and not moving
        /// </summary>
        public Base()
        {
            Height = 5;
            Width = 5;
            Color = Brushes.Red;

            X = 0;
            XSpeed = 1;
            MovingX = 0;
            Y = 0;
            XSpeed = 1;
            MovingY = 0;
        }

        /// <summary>
        /// Not the default constructor used for manually setting the objects attributes
        /// </summary>
        /// <param name="height"> sets objects Height dimension </param>
        /// <param name="width"> sets objects width diension </param>
        /// <param name="color"> sets objects color </param>
        /// <param name="x_speed"> sets the x speed of the object</param>
        /// <param name="y_speed"> sets the y speed of the object</param>
        public Base(int height, int width, Brush color, int x_speed, int y_speed)
        {
            // dimension and color
            Height = height;
            Width = width;
            Color = color;

            // position and speed
            X = 0;
            Y = 0;
            XSpeed = x_speed;
            YSpeed = y_speed;
            MovingX = 0;
            MovingY = 0;
        }

        public void Init(int x_pos, int y_pos, int x_speed, int y_speed)
        {
            X = 0;
            XSpeed = 1;
            Y = 0;
            XSpeed = 1;

        }

        /// <summary>
        /// Function responsible for moving the object bc position is a private attribute
        /// </summary>
        abstract public void MoveX(int x);//movement is multiplied by int to get up down left right movemet
        
        /// <summary>
        /// Function responsible for moving the object bc position if a private attribute
        /// </summary>
        /// <param name="y"></param>
        abstract public void MoveY(int y);

        abstract public bool StopMoveX(int x);
        abstract public bool StopMoveY(int y);

        //abstract class that needs to be set
        abstract public bool Reset();




    }
}
