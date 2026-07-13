#pragma once
#include "defines.h"
#include "Objects/Class/Screen.h"

extern "C"
{
	Y5LIB_EXPORT void OE_LIB_SCREEN_WORLDTOSCREENRATIO(__m128* in,__m128* out)
	{
		__m128 v = screen::WorldToScreenRatio(in);
		*out = v;
	}

	Y5LIB_EXPORT void OE_LIB_SCREEN_SCREENRATIOTOPIXELS(__m128* in, __m128* out)
	{
		__m128 pixels = screen::ScreenRatioToPixels(in);
		*out = pixels;
	}
}