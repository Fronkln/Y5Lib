#pragma once

class Fighter;

class FighterMode
{
public:
	void* modeVfPtr; //0x0000
	char pad_0008[8]; //0x0008
	char* modeName; //0x0010
	char pad_0018[8]; //0x0018
	Fighter* fighter; //0x0020
	char pad_0028[300]; //0x0028
}; //Size: 0x0154

class FighterModeManager;

typedef void* (__fastcall* FIGHTERMODEMANAGER_SetCommandSet)(FighterModeManager* fModeMan, int unk1, const char* commandsetName);

class FighterModeManager
{
public:
	void* vfptr; //0x0000
	class FighterMode* currentMode; //0x0008
	char pad_0010[24]; //0x0010
	class Fighter* fighter; //0x0028
	char pad_0030[216]; //0x0030

	static FIGHTERMODEMANAGER_SetCommandSet ASM_SetCommandset;

	void SetCommandset(int unk1, const char* commandsetName)
	{
		ASM_SetCommandset(this, unk1, commandsetName);
	}
}; //Size: 0x0108