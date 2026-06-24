#pragma once
class FighterCombatInfo
{
public:
	char pad_0000[22]; //0x0000
	unsigned short health; //0x0016
	unsigned short maxHealth; //0x0018
	char pad_001A[2]; //0x001A
	float heat; //0x001C
	float maxHeat; //0x0020
	char pad_0024[348]; //0x0024
}; //Size: 0x0180
