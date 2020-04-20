#pragma once


#ifdef PGEAPI_EXPORTS
#define PGE_API __declspec(dllexport)  
#else
#define PGE_API __declspec(dllimport)  
#endif

extern "C" PGE_API void PGEAPI_CreateEngineObject();

extern "C" PGE_API int  PGEAPI_Construct(
	int32_t screen_w, int32_t screen_h, int32_t pixel_w, int32_t pixel_h,
	bool full_screen, bool vsync);

extern "C" PGE_API void  PGEAPI_Start();


//Callbacks
extern "C" PGE_API void PGEAPI_OnUserCreate_set(OnUserCreate_func func);
extern "C" PGE_API void PGEAPI_OnUserUpdate_set(OnUserUpdate_func func);

//General Properties
extern "C" PGE_API void PGEAPI_sAppName_set(const char* newAppName);


//Draw functions
extern "C" PGE_API void PGEAPI_Draw(int x, int y, olc::Pixel * pixel);

