#pragma once
#include "EntityManagementMethod.h"
#include "Wanderer.h"

class LinkedListNode_Wanderer;

class CActionWandererManager : public EntityManagementMethod
{
public:
	char pad_01D0[64]; //0x01D0
	class LinkedListNode_Wanderer* activeWanderers; //0x0210
	char pad_0218[256]; //0x0218
	int32_t maximumWanderers; //0x0318
	int32_t presentWanderers; //0x031C
	char pad_0320[56]; //0x0320
	int32_t maximumWanderers2; //0x0358
	char pad_035C[1388]; //0x035C
	uint32_t bumpType; //0x08C8
	char pad_08CC[580]; //0x08CC
	vec4f checkPosition; //0x0B10 main camera position by default
}; //Size: 0x0B20
