
#define OLC_PGE_APPLICATION
#include "olcPixelGameEngine.h"
#include "types.h"
#include "PGEHost.h"


namespace olc
{

		bool PGEHost::OnUserCreate()
		{
			// Called once at the start, so create things here
			if (remoteOnUserCreate != nullptr)
			{
				return remoteOnUserCreate();
			}
			else
				return false;
		}

		bool PGEHost::OnUserUpdate(float fElapsedTime)
		{
			if (remoteOnUserUpdate != nullptr)
				return remoteOnUserUpdate(fElapsedTime);
			else
				return false;
			
			// called once per frame, draws random coloured pixels
			/*
			for (int x = 0; x < ScreenWidth(); x++)
				for (int y = 0; y < ScreenHeight(); y++)
					Draw(x, y, olc::Pixel(rand() % 256, rand() % 256, rand() % 256));
			return true;
			*/

		}

		void PGEHost::OnUserCreate_setFunc(OnUserCreate_func func)
		{
			remoteOnUserCreate = func;
		}

		void PGEHost::OnUserUpdate_setFunc(OnUserUpdate_func func)
		{
			remoteOnUserUpdate = func;
		}


}