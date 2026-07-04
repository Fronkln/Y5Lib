#pragma once
#include "pch.h"
// Created with ReClass.NET 1.2 by KN4CK3R

#pragma pack(push, 1)
class CActionManager
{
public:
	int64_t* vfPtr; //0x0000
	char pad_0008[8]; //0x0008
	uint32_t gamePaused; //0x0010
	uint32_t unpausedTime; //0x0014
	uint32_t unpausedTime2; //0x0018
	uint32_t generalTime; //0x001C
	uint32_t totalTimeSinceStartup; //0x0020
	uint32_t isLoaded; //0x0024
	char pad_0028[4]; //0x0028
	int32_t N000056FE; //0x002C
	char pad_0030[268]; //0x0030
	float fixedDeltaTime; //0x013C
	float fixedDeltaTime2; //0x0140
	float deltaTime; //0x0144
	char pad_0148[16]; //0x0148
	uint32_t actionMode; //0x0158
	uint32_t actionModeBitwise; //0x015C
	int32_t actionModeStackCount; //0x0160
	int32_t actionModeStack[16]; //0x0164
	int32_t regActionModeStackCount; //0x01A4
	int32_t regActionModeStack[16]; //0x01A8
	float speed[16]; //0x01E8
	char pad_0228[40]; //0x0228
	class CActionCtrlTypeManager* controlTypeManager; //0x0250
	class CActionFighterManager* actionFighterManager; //0x0258
	class CActionMotionManager* actionMotionManager; //0x0260
	class CActionFighterManager* actionFighterManager2; //0x0268
	char pad_0270[8]; //0x0270
	class CActionStageManager* actionStageManager; //0x0278
	char pad_0280[216]; //0x0280
	void* actionRangeManager; //0x0358
	char pad_0360[16]; //0x0360
	class CActionAuthManager* actionAuthManager; //0x0370
	class CActionHActManager* actionHActManager; //0x0378
	class CActionCCCManager* cccManager; //0x0380
	char pad_0388[8]; //0x0388
	void* cccc; //0x0390
	char pad_0398[32]; //0x0398
	void* actionWandererManager; //0x03B8
	char pad_03C0[184]; //0x03C0
	class CActionMenu* menu; //0x0478
	char pad_0480[368]; //0x0480
	class CActionHActCHPManager* actionHActCHPManager;  //0x05F0
	char pad_05F8[24]; //0x05F8
	class CActionCameraManager* actionCameraManager; //0x0610
	char pad_0618[8]; //0x0618
	class CActionBattleEndManager* actionBattleEndManager; //0x0620
	char pad_0628[80]; //0x0628
	class CActionSoundBGMManager* soundBgmManager; //0x0678
	void* soundManager; //0x0680
	char pad_0688[488]; //0x0688
	class CActionDriveManager* actionDriveManager; //0x0870
	char pad_0878[432]; //0x0878
	class CActionReactorManager* reactorManager; //0x0A28
	char pad_0A30[16]; //0x0A30
	class CActionPrincessLeagueManager* princessLeagueManager; //0x0A40
	class CActionLiveBattleManager* liveBattleManager; //0x0A48
	char pad_0A50[8]; //0x0A50
	class N00003DAE* danceManager; //0x0A58
	class CActionDanceBattleManager* danceBattleManager; //0x0A60
	class CActionDanceEventManager* danceEventManager; //0x0A68
	char pad_0A70[16]; //0x0A70
	class CActionEnemyDisposeManager* enemyDisposeManager; //0x0A80
	char pad_0A88[240]; //0x0A88
	class CActionSnowballManager* snowballManager; //0x0B78
	char pad_0B80[312]; //0x0B80
	class CActionUltimateSelect* ultimateSelect; //0x0CB8
	char pad_0CC0[128]; //0x0CC0
	class CActionChudan* chudan; //0x0D40
	char pad_0D48[10944]; //0x0D48

}; //Size: 0x1808
#pragma pack(pop, 1)
