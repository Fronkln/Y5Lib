#pragma once
#include "pch.h"
#include "EntityBase.h"
#include "EntityMotion.h"

#pragma pack(push, 1)

class Entity : public EntityBase
{
public:
	char pad_0028[40]; //0x0028
	uint32_t UID; //0x0050
	char pad_0054[28]; //0x0054
	vec4f Position; //0x0070
	char pad_0080[4]; //0x0080
	int32_t RotationY; //0x0084
	char pad_0088[8]; //0x0088
	void* InputController; //0x0090
	void* N00003BE3; //0x0098
	char pad_00A0[144]; //0x00A0
	char* ClassName; //0x0130
	char pad_0138[8]; //0x0138
}; //Size: 0x008C

#pragma pack(pop)