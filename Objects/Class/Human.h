#pragma once
#include "Entity.h"

#pragma pack(push, 1)

class MotionThingy;

class Human : public Entity
{
public:
	Motion::EntityMotion* Motion; //0x0140
	char pad_0148[24]; //0x0148
	class HumanModel* Model; //0x0160
	char pad_0168[1208]; //0x0168
	void* N00004915; //0x0620
	char pad_0628[128]; //0x0628
}; //Size: 0x06A4

#pragma pack(pop)