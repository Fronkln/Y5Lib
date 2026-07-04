#pragma once
#include "pch.h"
#include "Objects/Struct/FighterCommandID.h"
#include <cstdint>
class SyncPair
{
public:
	char pad_0000[12]; //0x0000
	int32_t fighterIndex; //0x000C
	char pad_0010[8]; //0x0010
}; //Size: 0x0018

class SyncRegisterData
{
public:
	void* vfptr; //0x0000
	char pad_0008[8]; //0x0008
	vec4f position; //0x0010
	int32_t rotY; //0x0020
	char pad_0024[12]; //0x0024
	int32_t serial; //0x0030
	FighterCommandID command; //0x0034
	uint8_t pairCount; //0x0038
	char pad_0039[31]; //0x0039
	class SyncPair* syncPairs; //0x0058
}; //Size: 0x0060