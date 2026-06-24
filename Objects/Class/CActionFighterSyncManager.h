#pragma once
#include <cstdint>
#include "..\Struct\FighterCommandID.h"

class CActionFighterSyncManager
{
	typedef int(__fastcall* _StartSync)(void* thisPtr, FighterCommandID& command, int initiatorFighterIndex, int targetFighterIndex);

	static _StartSync ASM_StartSync;

public:
	void* vfptr; //0x0000
	char pad_0008[8]; //0x0008
	int32_t currentSyncSerial; //0x0010
	char pad_0014[12]; //0x0014
	class SyncRegisterData* (*syncsToMakeDataPtr)[8]; //0x0020
	int64_t syncsToMake; //0x0028
	class SyncRegisterData* syncsToMakeData[8]; //0x0030
	void* activeSyncDatas; //0x0070
	int64_t activeSyncs; //0x0078
	char pad_0080[64]; //0x0080

	int StartSync(FighterCommandID& command, int initiatorFighterIndex, int targetFighterIndex)
	{
		return ASM_StartSync(this, command, initiatorFighterIndex, targetFighterIndex);
	}
}; //Size: 0x0080