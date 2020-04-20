using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace olc
{
    public abstract partial class PixelGameEngine
    {
        Random _rnd;

        public PixelGameEngine()
        {
           //Create the PixelGameEngine host object in C++
            cfunc.PGEAPI_CreateEngineObject();

            //Setup the call back funtions for OnUserCreate & OnUserUpdate
            cfunc.OnUserCreate_Delegate = new cfunc.OnUserCreate_Callback(this.OnUserCreate);
            cfunc.PGEAPI_OnUserCreate_set(cfunc.OnUserCreate_Delegate);

            cfunc.OnUserUpdate_Delegate = new cfunc.OnUserUpdate_Callback(this.OnUserUpdate);
            cfunc.PGEAPI_OnUserUpdate_set(cfunc.OnUserUpdate_Delegate);

            //TODO: Implement OnUserDestory

            _rnd = new Random();
        }

        public rcode Construct  (int screen_w, int screen_h, int pixel_w, int pixel_h,
                                    bool full_screen = false, bool vsync = false)
        {
            //rcode _retValue;
            //_retValue = (rcode)cfunc.PGEAPI_Construct(screen_w, screen_h, pixel_w, pixel_h, full_screen, vsync);
            //return _retValue;


            _screenWidth = screen_w;
            _screenHeight = screen_h;

            return (rcode)cfunc.PGEAPI_Construct(screen_w, screen_h, pixel_w, pixel_h, full_screen, vsync); 

        }

        public void Start()
        {
            cfunc.PGEAPI_Start();
        }

        public abstract bool OnUserCreate();
        public abstract bool OnUserUpdate(float fElapsedTime);

        protected int rand(int MaxValue, bool baseZero = true)
        {
            if (baseZero)
                return _rnd.Next(0, MaxValue);
            else
                return _rnd.Next(1, MaxValue);
        }

        //Public properties
        
        //sAppName
        private string _sAppName = "";
        public string sAppName
        {
            set
            {
                cfunc.PGEAPI_sAppName_set(value);
                _sAppName = value; 
            }
            get { return _sAppName; }
        }

        //ScreenWidth
        private int _screenWidth;
        public int ScreenWidth
        {
            get { return _screenWidth; }
        }

        //ScreenHeight
        private int _screenHeight;
        public int ScreenHeight
        {
             get { return _screenHeight; }
        }
            





    }
}
