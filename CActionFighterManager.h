#pragma once
#include <cstdint>
#include "Objects/Class/CActionFighterSyncManager.h"
#include "Objects/Class/CActionBase.h"

class Fighter;
class DisposeInfo;

class CActionFighterManager : public CActionBase
{
	typedef int(__fastcall* _ProcessDisposeQueue)(void* thisPtr);
	typedef int(__fastcall* _AddToDisposeQueue)(void* thisPtr, void* inf);

	typedef Fighter*(__fastcall* _GetFighterByUID)(void* thisPtr, int fighterUID);

private:
	static _ProcessDisposeQueue ASM_ProcessDisposeQueue;
	static _AddToDisposeQueue ASM_AddToDisposeQueue;
	
	static _GetFighterByUID ASM_GetFighterByUID;

public:
	char pad_01C8[8]; //0x01C8
	CActionFighterSyncManager fighterSyncManager; //0x01D0
	class Fighter* Fighters[63]; //0x0290
	uint64_t unkFighters; //0x0488
	uint64_t presentFighters; //0x0490
	uint64_t fightersToCreate; //0x0498
	uint64_t fightersToDestroy; //0x04A0
	char pad_04A8[316]; //0x04A8
	int32_t playerIdx; //0x05E4
	char pad_05E8[80]; //0x05E8

	Fighter* GetFighter(unsigned int index)
	{
		int test = sizeof(CActionFighterSyncManager);
		return Fighters[index];
	}

	int AddToDisposeQueue(DisposeInfo* spawn)
	{
		return ASM_AddToDisposeQueue(this, spawn);
		//return ASM_ProcessDisposeQueue(this);
	}

	void ProcessDisposeQueue() 
	{
		ASM_ProcessDisposeQueue(this);
	}

	Fighter* GetFighterByUID(int uid)
	{
		return ASM_GetFighterByUID(this, uid);
	}

}; //Size: 0x0638
