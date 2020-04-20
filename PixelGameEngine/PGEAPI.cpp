#include "olcPixelGameEngine.h"
#include "types.h"
#include "PGEHost.h"
#include "PGEAPI.h"

olc::PGEHost *pgeHost;

void PGEAPI_CreateEngineObject()
{
	pgeHost = new olc::PGEHost();

}

int PGEAPI_Construct(
	int32_t screen_w, int32_t screen_h, int32_t pixel_w, int32_t pixel_h,
	bool full_screen, bool vsync)
{
	if (pgeHost != nullptr)
		return static_cast<int>(pgeHost->Construct(screen_w, screen_h, pixel_w, pixel_h, full_screen, vsync));
	else
		return 0;
}

void PGEAPI_Start()
{
	if (pgeHost != nullptr)
		pgeHost->Start();
}



//CALLBACKS
void PGEAPI_OnUserCreate_set(OnUserCreate_func func)
{
	if (pgeHost != nullptr)
		pgeHost->OnUserCreate_setFunc(func);
}

void PGEAPI_OnUserUpdate_set(OnUserUpdate_func func)
{
	if (pgeHost != nullptr)
		pgeHost->OnUserUpdate_setFunc(func);
}

//General properties
void PGEAPI_sAppName_set(const char* newAppName)
{
	if (pgeHost != nullptr)
		pgeHost->sAppName = newAppName;
}

//DRAW FUNCTIONS

void PGEAPI_Draw(int x, int y, olc::Pixel *pixel)
{
	if (pgeHost != nullptr)
		//pgeHost->Draw(x, y, *pixel);
		pgeHost->Draw(x, y, olc::Pixel(pixel->r, pixel->g, pixel->b));
}

