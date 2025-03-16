#pragma once
#include "Objects/Struct/MissionData.h"

class CSequenceManager
{
public:
	void* vfptr; //0x0000
	char pad_0008[72]; //0x0008
	MissionData* missionData; //0x0050
	char pad_0058[40]; //0x0058
}; //Size: 0x0080