#pragma once
#include "Human.h"
#include "..\Struct\DamageInfo.h"
#include "..\Struct\DisposeInfo.h"
#include "..\Struct\FighterCombatInfo.h"

class DelegateMaybe
{
public:
	int32_t N000098DA; //0x0000
	char pad_0004[8]; //0x0004
	int32_t N00009946; //0x000C
	void* delegate; //0x0010
}; //Size: 0x0018

class FighterInputInfo
{
public:
	float forwardRelated; //0x0000
	int16_t sideRelated1; //0x0004
	int16_t sideRelated2; //0x0006
	int32_t buttonMask; //0x0008
}; //Size: 0x000C


typedef void (__fastcall* FIGHTER_ToDead)(void* Fighter);


#pragma pack(1)
class Fighter : public Human
{
private:
	static FIGHTER_ToDead ASM_ToDead;

public:
	class DisposeInfo disposeInfo; //0x1700
	uint32_t fighterIndex; //0x17B0
	int32_t ctrlType; //0x17B4
	char pad_17B8[12]; //0x17B8
	int32_t thinkMode; //0x17C4
	char pad_17C8[168]; //0x17C8
	class AttackInfo* AttackInfo; //0x1870
	uint32_t damageInfosToProcess; //0x1878
	char pad_187C[4340]; //0x187C
	class DamageInfo toProcessDamageInf; //0x2970
	char pad_2A00[112]; //0x2A00
	class FighterInputInfo InputInfo; //0x2A70
	char pad_2A7C[1460]; //0x2A7C
	class UnknownFighterClass* unknownFighterClass; //0x3030
	class UnknownFighterClass2* unknownFighterClass2; //0x3038
	char pad_3040[352]; //0x3040
	class FighterCombatInfo CombatInfoData; //0x31A0
	char pad_3320[256]; //0x3320
	class FighterCombatInfo* CombatInfoPtr; //0x3420
	char pad_3428[8]; //0x3428
	unsigned int fighterFlags; //0x3430
	char pad_3434[12]; //0x3434
	class FighterModeManager* fighterModeManager; //0x3440
	char pad_3448[8]; //0x3448
	int32_t syncSerial; //0x3450
	char pad_3454[284]; //0x3454
	int32_t N00004F00; //0x3570
	int32_t currentFighterMode; //0x3574
	char pad_3578[496]; //0x3578
	class pxd_hash currentModeName; //0x3768
	char pad_3788[24]; //0x3788

	void ToDead()
	{
		ASM_ToDead(this);
	}
}; //Size: 0x37A0
#pragma pack(pop)