#pragma once
#include <cstdint>
#include "Objects/Struct/pxd_hash.h"

class CHActEntry
{
public:
	int32_t N00002572; //0x0000
	char pad_0004[4]; //0x0004
	class CHAct* hact; //0x0008
	pxd_hash name; //0x0010
}; //Size: 0x0030

class CHAct
{
public:
	void* vfptr; //0x0000
	char pad_0008[8]; //0x0008
	int32_t status; //0x0010
	int32_t flags; //0x0014
	int32_t N00002774; //0x0018
	char pad_001C[12]; //0x001C
	void* N00002776; //0x0028
	char pad_0030[24]; //0x0030
	void* N000023B9; //0x0048
	char pad_0050[288]; //0x0050
	void* N000023DE; //0x0170
	char pad_0178[8]; //0x0178
	char name[256]; //0x0180
	char pad_0280[4]; //0x0280
	char path[256]; //0x0284
	char pad_0384[2]; //0x0384
	void* N000023E2; //0x0386
	char pad_038E[32]; //0x038E
	void* N000023E7; //0x03AE
	char pad_03B6[6]; //0x03B6
	float currentTime; //0x03BC
	float previousTime; //0x03C0
	float startFrame; //0x03C4
	float N000023EA; //0x03C8
	float endFrame; //0x03CC
	float N000023EB; //0x03D0
	float timeStep; //0x03D4
	char pad_03D8[88]; //0x03D8
	Matrix4x4 transform; //0x0430
	char pad_0470[192]; //0x0470
	int32_t phase; //0x0530
	char pad_0534[2308]; //0x0534
}; //Size: 0x0E38