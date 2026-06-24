#pragma once
#include "CActionBase.h"
#include "Objects/Struct/EnemyDisposeInfo.h"

class CActionEnemyDisposeManager
{
public:
	char pad_0000[1008]; //0x0000
	struct EnemyDisposeInfo* enemyDisposesStart; //0x03F0
	int32_t enemyDisposesCount; //0x03F8
	char pad_03FC[4]; //0x03FC
	struct EnemyDisposeInfo enemyDisposes[32]; //0x0400
	char pad_1C00[32]; //0x1C00
	char startHAct[30]; //0x1C20
	char pad_1C3E[14930]; //0x1C3E
}; //Size: 0x5690