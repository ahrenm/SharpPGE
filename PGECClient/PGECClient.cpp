#include <stdint.h>
#include "..\PixelGameEngine\types.h"
#include "..\PixelGameEngine\PGEAPI.h"


void CallBackTest()
{
	PGEAPI_sAppName_set("TEST");
}

int main()
{
	if (PGEAPI_Construct(200, 200, 2, 2, false, false))
	{
		//Callback testing
		//PGEAPI_OnUserCreate_Set(CallBackTest);


		PGEAPI_Start();
	}

}

