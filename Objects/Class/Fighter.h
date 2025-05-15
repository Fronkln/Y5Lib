#pragma once
#include "Human.h"

class DelegateMaybe
{
public:
	int32_t N000098DA; //0x0000
	char pad_0004[8]; //0x0004
	int32_t N00009946; //0x000C
	void* delegate; //0x0010
}; //Size: 0x0018

#pragma pack(1)
class Fighter : public Human
{
public:
	char pad_06A8[72]; //0x06A8
	class DelegateMaybe delegatesMaybe[17]; //0x06F0
	char pad_0888[1528]; //0x0888
	class MotionRelatedClass2* MotionRelatedPointer; //0x0E80
	char pad_0E88[2168]; //0x0E88
	class DisposeInfo disposeInfo; //0x1700
	uint32_t fighterIndex; //0x17B0
	char pad_17B4[4796]; //0x17B4
	float N00001D0A; //0x2A70
	uint16_t N00004DA1; //0x2A74
	uint16_t N00001D0D; //0x2A76
	int32_t inputFlags; //0x2A78
	char pad_2A7C[1460]; //0x2A7C
	class UnknownFighterClass* unknownFighterClass; //0x3030
	class UnknownFighterClass2* unknownFighterClass2; //0x3038
	char pad_3040[1024]; //0x3040
	class FighterModeManager* fighterModeManager; //0x3440
	char pad_3448[296]; //0x3448
	int32_t N00004F00; //0x3570
	int32_t currentFighterMode; //0x3574
	char pad_3578[496]; //0x3578
	class pxd_hash currentModeName; //0x3768
	char pad_3788[24]; //0x3788
}; //Size: 0x37A0
#pragma pack(pop)