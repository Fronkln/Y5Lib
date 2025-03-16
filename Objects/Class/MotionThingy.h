#pragma once
#include "pch.h"
#include "UnknownMotionComponent.h"

//UnkMotionSection does not exist in Mannequins

class MotionThingy
{
public:
	char pad_0000[8]; //0x0000
	class N0000680D* N00000DA7; //0x0008
	Matrix4x4 Scale; //0x0010
	vec4f Motion; //0x0050
	char pad_0060[48]; //0x0060
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
	char pad_0144[3364]; //0x0144
	UnknownMotionComponent* UnkMotionSection; //0x0E68
	char pad_0E70[160]; //0x0E70
	vec4f N00000FAD; //0x0F10
	int16_t rotY; //0x0F20
	char pad_0F22[22]; //0x0F22
	vec4f N00000FB1; //0x0F38
	char pad_0F48[40]; //0x0F48
	vec4f N00000FB7; //0x0F70
	char pad_0F80[8]; //0x0F80
	vec4f N00000FB9; //0x0F88
	vec4f N00000FBA; //0x0F98
	vec4f N00000FBB; //0x0FA8
	vec4f N00000FBC; //0x0FB8
	char pad_0FC8[440]; //0x0FC8
}; //Size: 0x1180