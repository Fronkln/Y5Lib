#pragma once
#include "pch.h"
#include <cstdint>

struct FontSettings
{
public:
	int32_t xPos; //0x0008
	int32_t yPos; //0x000C
	int16_t N000067F3; //0x0010
	int16_t N000067FA; //0x0012
	float N000067EB; //0x0014
	uint8_t colorR; //0x0018
	uint8_t colorG; //0x0019
	uint8_t colorB; //0x001A
	uint8_t colorA; //0x001B
	char pad_001C[4]; //0x001C
	uint8_t N00006799; //0x0020
	uint8_t N0000679F; //0x0021
	uint8_t N000067A3; //0x0022
	uint8_t N000067A0; //0x0023
	int32_t N00006700; //0x0024
	int32_t N00006800; //0x0028
	vec2f scale; //0x002C
	int32_t N000067EF; //0x0034
	int32_t N00006795; //0x0038
	int32_t N000067F0; //0x003C
};

class CFont
{
	typedef void(__fastcall* _PushText)(void* font, const char* text);

	static _PushText ASM_PushText;

public:
	void* vfptr; //0x0000
	FontSettings settings;

	void PushText(const char* string)
	{
		ASM_PushText(this, string);
	}
}; //Size: 0x0040