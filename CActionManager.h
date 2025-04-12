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
	float speed[16]; //0x01E8
	char pad_0228[48]; //0x0228
	void* actionFighterManager; //0x0258
	char pad_0260[8]; //0x0260
	void* actionFighterManager2; //0x0268
	char pad_0270[928]; //0x0270
	class CActionCameraManager* actionCameraManager; //0x0610
	char pad_0618[1064]; //0x0618
	class CActionPrincessLeagueManager* princessLeagueManager; //0x0A40
	char pad_0A48[24]; //0x0A48
	class CActionDanceBattleManager* danceBattleManager; //0x0A60
	char pad_0A68[11680]; //0x0A68
}; //Size: 0x1808
#pragma pack(pop, 1)
