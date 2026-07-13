#pragma once
#include "pch.h"

class CHumanDraw
{
public:
	void* vfptr; //0x0000
	char pad_0008[44]; //0x0008
	int32_t heightIndex; //0x0034
	char pad_0038[8]; //0x0038
	class pxd_hash modelName; //0x0040
	class pxd_hash modelName2; //0x0060
	char pad_0080[600]; //0x0080
	class CHumanInfo* humanInfo; //0x02D8
	char pad_02E0[1200]; //0x02E0
	class Human* owner; //0x0790
	char pad_0798[64]; //0x0798
	int32_t voicerID; //0x07D8
	char pad_07DC[36]; //0x07DC
}; //Size: 0x0800