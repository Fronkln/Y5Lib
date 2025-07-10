#pragma once
#include "pch.h"
#include "CActionBase.h"

class CHPTarget
{
public:
	uint32_t ID; //0x0000
	char pad_0004[4]; //0x0004
}; //Size: 0x0008

class HActRegister
{
public:
	char pad_0000[16]; //0x0000
	vec4f position; //0x0010
	char pad_0020[4]; //0x0020
	int32_t UIDSerial; //0x0024
	char pad_0028[16]; //0x0028
	uint16_t rotY; //0x0038
	char pad_003A[22]; //0x003A
}; //Size: 0x0050

class CActionHActCHPManager : public CActionBase
{
public:
	class CHPTarget chpNearestTargets[63]; //0x01C8
	int32_t chpTargetsCount; //0x03C0
	char pad_03C4[12]; //0x03C4
	pxd_hash uniqueHactsPlayed[32]; //0x03D0
	char pad_07D0[40]; //0x07D0
	int32_t uniqueHActsPlayedCount; //0x07F8
	char pad_07FC[20]; //0x07FC
	class CFileBase* fileHActChp; //0x0810
	char pad_0818[32]; //0x0818
	pxd_hash currentHAct; //0x0838
	char pad_0858[136]; //0x0858
	class HActRegister characterRegisters[32]; //0x08E0
	char pad_12E0[11]; //0x12E0
	bool isPlaying; //0x12EB
	char pad_12EC[260]; //0x12EC
	Matrix4x4 N00002925; //0x13F0
	char pad_1430[32]; //0x1430
	class HActRegister someRegisters[32]; //0x1450
	char pad_1E50[368]; //0x1E50
}; //Size: 0x1FC0