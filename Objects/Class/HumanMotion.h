#pragma once
#include "BoneMotion.h"
#include "UnknownMotionComponent.h"

typedef int(__fastcall* HumanMotion_SetPosition)(void* thisPtr, vec4f* pos);

namespace Motion
{
	class HumanMotion : public Motion::BoneMotion
	{
		static HumanMotion_SetPosition ASM_SetPosition;

	public:
		char pad_0620[1944]; //0x0620
		uint32_t flags; //0x0DB8
		char pad_0DBC[172]; //0x0DBC
		class UnknownMotionComponent* collisionShape; //0x0E68
		char pad_0E70[160]; //0x0E70
		vec4f position2; //0x0F10
		uint16_t rotY; //0x0F20
		char pad_0F22[14]; //0x0F22
		vec4f position3; //0x0F30
		char pad_0F40[48]; //0x0F40
		vec4f position4; //0x0F70
		vec4f position5; //0x0F80
		vec4f position6; //0x0F90
		vec4f position7; //0x0FA0
		char pad_0FB0[228]; //0x0FB0
		uint32_t motionMode; //0x1094
		char pad_1098[8]; //0x1098

		void SetPosition(vec4f* pos)
		{
			ASM_SetPosition(this, pos);
		}
	}; //Size: 0x10A0
}