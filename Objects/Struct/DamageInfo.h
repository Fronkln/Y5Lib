#pragma once
#include "..\..\pch.h"
class DamageInfo
{
public:
	vec4f hitPos; //0x0000
	vec4f hitPos2; //0x0010
	vec4f N000056F7; //0x0020
	int32_t N000056F8; //0x0030
	int32_t attackerFID; //0x0034
	char pad_0038[58]; //0x0038
	int16_t hitboxLocation1; //0x0072
	int16_t hitEffect; //0x0074
	int16_t hitStrength; //0x0076
	char pad_0078[8]; //0x0078
	uint16_t damage; //0x0080
	char pad_0082[14]; //0x0082
}; //Size: 0x0090