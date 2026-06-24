#pragma once
#include <cstdint>


class CFCMove
{
public:
	char pad_0000[4]; //0x0000
	uint8_t numFollowups; //0x0004
	char pad_0005[1]; //0x0005
	char moveType; //0x0006
	char pad_0007[1]; //0x0007
	int32_t somePointer; //0x0008
	uint8_t N00007CD5; //0x000C
	char pad_000D[114]; //0x000D
}; //Size: 0x007F