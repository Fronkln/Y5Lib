#pragma once
#include "pch.h"

class MissionData
{
public:
	int32_t N000034A3; //0x0000
	int32_t playerPosToApply; //0x0004
	char pad_0008[8]; //0x0008
	class pxd_hash playerModel; //0x0010
	int32_t N000034AA; //0x0030
	int32_t N000034CC; //0x0034
	int32_t applyPlayerPos; //0x0038
	char pad_003C[4]; //0x003C
	unsigned int missionID; //0x0040
	int32_t N000034D0; //0x0044
	char pad_0048[52]; //0x0048
	int32_t prohibitTransition; //0x007C when set to 1 prevented the battle sequence from ending
	char pad_0080[124]; //0x0080
	int32_t N00014CA7; //0x00FC
	char pad_0100[128]; //0x0100
	int32_t playerPosIdx; //0x0180
	char pad_0184[432]; //0x0184
	int32_t stageID; //0x0334
	char pad_0338[72]; //0x0338
	vec4f playerPosition; //0x0380
	int32_t playerRotationY; //0x0390
	char pad_0394[4]; //0x0394
	class pxd_hash actualPlayerModel; //0x0398
	char pad_03B8[120]; //0x03B8
	class pxd_hash startHAct; //0x0430
	void* N0000447C; //0x0450
	int32_t startType; //0x0458 1-2 on battles with hact start, 3 otherwise
	char pad_045C[24]; //0x045C
	int32_t scenarioID; //0x0474
	char pad_0478[204]; //0x0478
}; //Size: 0x0544