#pragma once
#include "Entity.h"

#pragma pack(push, 1)

class MotionThingy;

class Human : public Entity
{
public:
	Motion::EntityMotion* Motion; //0x0140
	char pad_0148[64]; //0x0148
	void* N00003BF8; //0x0188
	char pad_0190[1304]; //0x0190
}; //Size: 0x06A4

#pragma pack(pop)