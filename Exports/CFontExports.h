#pragma once
#include "defines.h"
#include "Objects/Class/CFont.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{
	Y5LIB_EXPORT void OE_LIB_FONT_PUSH_SETTINGS(FontSettings* settings)
	{
		auto font = *OE::Font;

		if (font == nullptr)
			return;

		memcpy_s(&font->settings, sizeof(FontSettings), settings, sizeof(FontSettings));
	}

	Y5LIB_EXPORT void OE_LIB_FONT_PUSH_TEXT(const char* string)
	{
		auto font = *OE::Font;

		if (font == nullptr)
			return;

		font->PushText(string);
	}
}