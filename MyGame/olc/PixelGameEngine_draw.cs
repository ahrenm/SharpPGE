using System;
using System.Collections.Generic;
using System.Text;

namespace olc
{
    public abstract partial class PixelGameEngine
    {
        //DRAW FUNCTIONS

        public bool Draw(int x, int y)
        {
            return Draw(x,y, WHITE);
        }

        public bool Draw(int x, int y, Pixel p)
        {
            cfunc.PGEAPI_Draw(x, y, ref p);
            return true;
        }

    }
}
