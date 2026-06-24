#pragma once
#include "Objects/Struct/MissionData.h"

typedef void(__fastcall* CSEQUENCEMANAGER_LoadNextMission)();

class CSequenceManager
{
private:
	static CSEQUENCEMANAGER_LoadNextMission ASM_LoadNextMission;

public:
	void* vfptr; //0x0000
	char pad_0008[8]; //0x0008
	void* sequencePhaseDelegates[8]; //0x0010
	MissionData* missionData; //0x0050
	MissionData* nextMissionData; //0x0058
	char pad_0060[24]; //0x0060
	uint32_t sequencePhase; //0x0078
	char pad_007C[4]; //0x007C
	void* sequenceCommandDef; //0x0080
	int32_t isLoading; //0x0088
	char pad_008C[4]; //0x008C
	void* currentSequence; //0x0090
	void* nextSequence; //0x0098

	static void LoadNextMission() 
	{
		ASM_LoadNextMission();
	}
}; //Size: 0x0080