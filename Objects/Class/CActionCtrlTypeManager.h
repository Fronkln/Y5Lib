#pragma once
#include "CActionBase.h"

typedef void(__fastcall* CACTIONCTRLTYPEMANAGER_SetBattlePhase)(void* ctrlMan, int phase);

class CActionCtrlTypeManager : public CActionBase
{
	static CACTIONCTRLTYPEMANAGER_SetBattlePhase ASM_SetBattlePhase;

public:
	char pad_01C8[328]; //0x01C8
	int32_t battleStartType; //0x0310 1 encounter no hact, 2 and 5 hact
	int32_t battlePhase; //0x0314
	char pad_0318[8]; //0x0318
	int32_t allowPhaseProgress; //0x0320
	char pad_0324[4]; //0x0324
	int32_t battleSubPhase; //0x0328 starts from 0 each time battle phase changes
	float phaseTime; //0x032C
	pxd_hash battleStartHAct; //0x0330
	Matrix4x4 N00009B8F; //0x0350
	uint32_t battleStartGMT; //0x0390
	char pad_0394[12]; //0x0394

	void SetBattlePhase(int phase)
	{
		ASM_SetBattlePhase(this, phase);
	}
}; //Size: 0x03A0