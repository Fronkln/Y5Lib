#pragma once
#include "Human.h"

#pragma pack(1)
class Fighter : public Human
{
public:
	char pad_06A8[2008]; //0x06A8
	class MotionRelatedClass2* MotionRelatedPointer; //0x0E80
	char pad_0E88[2168]; //0x0E88
	DisposeInfo disposeInfo; //0x1700
	char pad_17AC[4800]; //0x17AC
	float N00001D0A; //0x2A70
	uint16_t N00004DA1; //0x2A74
	uint16_t N00001D0D; //0x2A76
	int32_t inputFlags; //0x2A78
	char pad_2A7C[2808]; //0x2A7C
	int32_t currentFighterMode; //0x3574
	char pad_3578[552]; //0x3578
}; //Size: 0x37A0
#pragma pack(pop)