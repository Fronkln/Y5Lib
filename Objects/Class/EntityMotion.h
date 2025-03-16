#pragma once
#include "pch.h"

namespace Motion
{
	class EntityMotion
	{
	public:
		int64_t* vfptr; //0x0000
		char pad_0008[8]; //0x0008
		Matrix4x4 Scale; //0x0010
		vec4f Position; //0x0050
		void* N000091AE; //0x0060
		char pad_0068[40]; //0x0068
	}; //Size: 0x0090
}