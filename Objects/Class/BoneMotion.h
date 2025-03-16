#pragma once
#include "EntityMotion.h"

namespace Motion
{
	class BoneMotion : public Motion::EntityMotion
	{
	public:
		Matrix4x4 Matrix; //0x0090
		char pad_00D0[4]; //0x00D0
		float animBlendX; //0x00D4
		char pad_00D8[8]; //0x00D8
		uint32_t CurrentAnim; //0x00E0
		float CurrentFrame; //0x00E4
		float PreviousFrame; //0x00E8
		float Unk; //0x00EC
		char pad_00F0[80]; //0x00F0
		uint32_t nextAnim; //0x0140
		char pad_0144[1244]; //0x0144
	}; //Size: 0x0620
}