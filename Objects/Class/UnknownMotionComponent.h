#pragma once
#include "pch.h"

class UnknownMotionComponent
{
public:
	char pad_0000[208]; //0x0000
	vec4f Position; //0x00D0
	char pad_00E0[48]; //0x00E0
}; //Size: 0x0110