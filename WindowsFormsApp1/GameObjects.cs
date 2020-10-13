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

        public void draw(Graphics GameGraphics)
        {
            GameGraphics.FillRectangle(Color, X, Y, Width, Height);
        }

        public void update()
        {
            if(MovingX != 0) // is it -1 or 1
            {
                X = X + (XSpeed * MovingX);
            }
            if(MovingY != 0) // is it -1 or 1
            {
                Y = Y + (YSpeed * MovingY);
            }
        }

        public override void MoveX(int x)
        {
            throw new NotImplementedException();
        }

        public override void MoveY(int y)
        {
            throw new NotImplementedException();
        }

        public override bool Reset()
        {
            throw new NotImplementedException();
        }

        public override bool StopMoveX(int x)
        {
            throw new NotImplementedException();
        }

        public override bool StopMoveY(int y)
        {

            throw new NotImplementedException();
        }
    }

    class Target : Base
    {
        public override void MoveX(int x)
        {
            throw new NotImplementedException();
        }

        public override void MoveY(int y)
        {
            throw new NotImplementedException();
        }

        public override bool Reset()
        {
            throw new NotImplementedException();
        }

        public override bool StopMoveX(int x)
        {
            throw new NotImplementedException();
        }

        public override bool StopMoveY(int y)
        {
            throw new NotImplementedException();
        }
    }

}
