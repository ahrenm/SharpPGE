using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace olc
{
    public abstract partial class PixelGameEngine
    {
        private class cfunc
        {


            [DllImport("PixelGameEngine.dll")]
            public static extern void PGEAPI_CreateEngineObject();

            [DllImport("PixelGameEngine.dll")]
            public static extern int PGEAPI_Construct(int screen_w, int screen_h, int pixel_w, int pixel_h, bool full_screen, bool vsync);

            [DllImport("PixelGameEngine.dll")]
            public static extern void PGEAPI_Start();

            //CALLBACK FUNCTIONS

            //OnUser Create
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate bool OnUserCreate_Callback();
            
            public static OnUserCreate_Callback OnUserCreate_Delegate; //GC Guard
            
            [DllImport("PixelGameEngine.dll",CallingConvention = CallingConvention.StdCall)]
            public static extern void PGEAPI_OnUserCreate_set(OnUserCreate_Callback func);

            //OnUserUpdate
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate bool OnUserUpdate_Callback(float fElapsedTime);

            public static OnUserUpdate_Callback OnUserUpdate_Delegate; //GC Guard

            [DllImport("PixelGameEngine.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern void PGEAPI_OnUserUpdate_set(OnUserUpdate_Callback func);


            //END CALLBACK FUNCTIONS

            //GENERAL PROPERTY CONTROLS

            //sAppName
            [DllImport("PixelGameEngine.dll")]
            public static extern void PGEAPI_sAppName_set(string sAppName);


            //END GENERAL PROPERTY CONTROLS

            //DRAW FUNCTIONS


            [DllImport("PixelGameEngine.dll")]
            public static extern void PGEAPI_Draw(int x, int y, ref Pixel pixel);


            //END DRAW FUNCTIONS


        }

    }
}
