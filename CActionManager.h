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
	char pad_0028[276]; //0x0028
	float fixedDeltaTime; //0x013C
	float fixedDeltaTime2; //0x0140
	float deltaTime; //0x0144
	char pad_0148[16]; //0x0148
	uint32_t N000014A6; //0x0158
	uint32_t N00006A6E; //0x015C
	int32_t N000014A7; //0x0160
	char pad_0164[132]; //0x0164
	float speed[15]; //0x01E8
	char pad_0224[44]; //0x0224
	class CActionControlTypeManager* controlTypeManager; //0x0250
	class CActionFighterManager* actionFighterManager; //0x0258
	class CActionMotionManager* actionMotionManager; //0x0260
	class CActionFighterManager* actionFighterManager2; //0x02688
	char pad_0270[264]; //0x0270
	class CActionHActManager* actionHActManager; //0x0378
	char pad_0380[248]; //0x0380
	void* N000081B0; //0x0478
	char pad_0480[400]; //0x0480
	class CActionCameraManager* actionCameraManager; //0x0610
	char pad_0618[1040]; //0x0618
	class CActionReactorManager* reactorManager; //0x0A28
	char pad_0A30[16]; //0x0A30
	class CActionPrincessLeagueManager* princessLeagueManager; //0x0A40
	class CActionLiveBattleManager* liveBattleManager; //0x0A48
	char pad_0A50[16]; //0x0A50
	class CActionDanceBattleManager* danceBattleManager; //0x0A60
	char pad_0A68[11680]; //0x0A68
}; //Size: 0x1808
#pragma pack(pop, 1)
