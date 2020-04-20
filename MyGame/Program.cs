using System;
using System.Windows.Forms;
using olc;

namespace MyGame
{
    public class MyGame : PixelGameEngine
    {
        public override bool OnUserCreate()
        {
            sAppName = "TEST";
            return true;
        }

        public override bool OnUserUpdate(float fElapsedTime)
        {
            for (int x = 0; x < ScreenWidth; x++)
                for (int y = 0; y < ScreenHeight; y++)
                    Draw(x, y, new Pixel((byte)rand(255) , (byte)rand(255), (byte)rand(255)));
            return true;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            MyGame demo = new MyGame();

            if (demo.Construct(256, 240, 2, 2) == PixelGameEngine.rcode.OK)
                demo.Start();
        }
    }
}
