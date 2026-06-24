#pragma once
#include "Fighter.h"

class Enemy : public Fighter
{
public:
	bool N00004EFF; //0x37A0
	bool N0000F893; //0x37A1
	bool N0000F897; //0x37A2
	bool N0000F89A; //0x37A3
	bool isUnkillable; //0x37A4
	char pad_37A5[3]; //0x37A5
	class EnemyController* enemyController; //0x37A8
	char pad_37B0[48]; //0x37B0
}; //Size: 0x37E0