using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class GameObjects
    {
    }

    class Base
    {
        /// <summary>
        /// General Properties
        /// </summary>
        public double Height { get; set; }
        public double Witdth { get; set; }
        public Brush Color { get; set; }


        /// <summary>
        /// Coordinates and Movement Speed
        /// </summary>
        public double X { get; set; }
        public double Y { get; set; }
        public double XSpeed { get; set; }
        public double YSpeed { get; set; }

    }
}
