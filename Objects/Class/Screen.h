#pragma once
#include "pch.h"
class screen
{
	typedef __m128(__fastcall* _WorldToScreenPointRatio)(__m128* vec);
	typedef __m128(__fastcall* _ScreenRatioToPixels)(__m128* vec, bool a1);
	
	static _WorldToScreenPointRatio ASM_WorldToScreenPointRatio;
	static _ScreenRatioToPixels ASM_ScreenRatioToPixels;

public:
	static __m128 WorldToScreenRatio(__m128* vec)
	{
		return ASM_WorldToScreenPointRatio(vec);
	}

	static __m128 ScreenRatioToPixels(__m128* vec)
	{
		return ASM_ScreenRatioToPixels(vec, false);
	}
};