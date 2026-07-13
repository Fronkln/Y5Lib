#pragma once
#include "..\Struct\DamageInfo.h"

class Fighter;
class FMDamageModule;
class FighterModeManager;

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

class FMDamageModule
{
public:
	void* vfptr; //0x0000
	class Fighter* fighter; //0x0008
	char pad_0010[16]; //0x0010
	class DamageInfo damageInfo; //0x0020
}; //Size: 0x00B0

typedef void* (__fastcall* FIGHTERMODEMANAGER_SetCommandSet)(FighterModeManager* fModeMan, int unk1, const char* commandsetName);
typedef FighterCommandID* (__fastcall* FIGHTERMODEMANAGER_GetCurrentCommand)(FighterModeManager* fModeMan, FighterCommandID& in_command);

class FighterModeManager
{
	static FIGHTERMODEMANAGER_SetCommandSet ASM_SetCommandset;
	static FIGHTERMODEMANAGER_GetCurrentCommand ASM_GetCurrentCommand;

public:
	class FighterMode* currentMode; //0x0008
	class FighterMode* nextMode; //0x0010
	int N00009A10; //0x0018
	char pad_001C[12]; //0x001C
	class Fighter* fighter; //0x0028
	char pad_0030[392]; //0x0030
	class FMDamageModule* DamageModule; //0x01B8
	char pad_01C0[96]; //0x01C0
	int32_t activeCommandset; //0x0220
	int32_t commandSets[3]; //0x0224
	char pad_0230[64]; //0x0230

	void SetCommandset(int unk1, const char* commandsetName)
	{
		ASM_SetCommandset(this, unk1, commandsetName);
	}

	FighterCommandID* GetCurrentCommand(FighterCommandID& in_command)
	{
		return ASM_GetCurrentCommand(this, in_command);
	}

	//Function definitions may be placeholder (missing arguments etc...)
	//Not all functions might be there as well
	virtual ~FighterModeManager() {};
	virtual void Func1();
	virtual void Update();
	virtual void Func3();
	virtual void Func4();
	virtual void Func5();
	virtual void Func6();
	virtual void Func7();
	virtual void Func8();
	virtual void Func9();
	virtual void Func10();
	virtual void Func11();
	virtual bool ToFall() { return 0; };
	virtual bool ToGuard() { return 0; };
	virtual bool ToKamae() { return 0; };
	virtual bool ToStand() { return 0; };
	virtual bool ToMove() { return 0; };
	virtual void Func17();
	virtual void Func18();
	virtual void ToDeadByDamage(DamageInfo* damage);
	virtual void ToStun();
	virtual void Func21();
	virtual void Func22();
	virtual void Func23();
	virtual void Func24();
	virtual void Func25();
	virtual void Func26();
	virtual void Func27();
	virtual void Func28();
	virtual void Func29();
	virtual void ToAttack(FighterCommandID command);
}; //Size: 0x0108