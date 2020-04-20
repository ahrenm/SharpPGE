using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace olc
{
    public abstract partial class PixelGameEngine
    {

        public enum rcode { FAIL = 0, OK = 1, NO_FILE = -1 };
        const byte nDefaultAlpha = 0xff;
        const int nDefaultPixel = (nDefaultAlpha << 24);

        [StructLayout(LayoutKind.Explicit)]
        public struct Pixel
        {
            [FieldOffset(0)] public int n;
            [FieldOffset(0)] public byte r;
            [FieldOffset(1)] public byte g;
            [FieldOffset(2)] public byte b;
            [FieldOffset(3)] public byte a;
            [FieldOffset(4)] public PixelMode Mode;

            public Pixel (int p)
            {
                r = 0;g = 0;b = 0;a = 0; //Hack to fool the complier 
                n = p;
                Mode = PixelMode.NORMAL;
            }

            public Pixel (byte red, byte green, byte blue, byte alpha = nDefaultAlpha)
            {
                n = 0; //Hack to fool the complier
                r = red; g = green; b = blue; a = alpha;
                Mode = PixelMode.NORMAL;
            }

            //TODO: Implement == and != operators
        }

        public enum PixelMode { NORMAL, MASK, ALPHA, CUSTOM };

        readonly Pixel GREY = new Pixel(192, 192, 192);
        readonly Pixel WHITE = new Pixel(255, 255, 255);
        //TOD: Implement the rest of these
        /*
        Pixel GREY(192, 192, 192), DARK_GREY(128, 128, 128), VERY_DARK_GREY(64, 64, 64),
		RED(255, 0, 0), DARK_RED(128, 0, 0), VERY_DARK_RED(64, 0, 0),
		YELLOW(255, 255, 0), DARK_YELLOW(128, 128, 0), VERY_DARK_YELLOW(64, 64, 0),
		GREEN(0, 255, 0), DARK_GREEN(0, 128, 0), VERY_DARK_GREEN(0, 64, 0),
		CYAN(0, 255, 255), DARK_CYAN(0, 128, 128), VERY_DARK_CYAN(0, 64, 64),
		BLUE(0, 0, 255), DARK_BLUE(0, 0, 128), VERY_DARK_BLUE(0, 0, 64),
		MAGENTA(255, 0, 255), DARK_MAGENTA(128, 0, 128), VERY_DARK_MAGENTA(64, 0, 64),
		WHITE(255, 255, 255), BLACK(0, 0, 0), BLANK(0, 0, 0, 0);
        */
    }
}
