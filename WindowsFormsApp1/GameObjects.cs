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
        public User()
        {
            Height = 10;
            Width = 11;
            Color = Brushes.Blue;


        }

        public void draw()
        {

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
