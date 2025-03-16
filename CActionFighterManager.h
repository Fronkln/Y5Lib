#pragma once
#include <cstdint>

class Fighter;
class DisposeInfo;

class CActionFighterManager
{
	typedef int(__fastcall* _ProcessDisposeQueue)(void* thisPtr);
	typedef int(__fastcall* _AddToDisposeQueue)(void* thisPtr, void* inf);

private:
	static _ProcessDisposeQueue ASM_ProcessDisposeQueue;
	static _AddToDisposeQueue ASM_AddToDisposeQueue;

public:
	char pad_0000[656]; //0x0000
	Fighter* Fighters[64]; //0x0290
	uint64_t presentFighters; //0x0490
	uint64_t fightersToCreate; //0x0498
	uint64_t fightersToDestroy; //0x04A0
	char pad_04A8[316]; //0x04A8
	int32_t playerIdx; //0x05E4
	char pad_05E8[80]; //0x05E8


	Fighter* GetFighter(unsigned int index)
	{
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

}; //Size: 0x0638