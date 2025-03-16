// Created with ReClass.NET 1.2 by KN4CK3R
#include <stdint.h>
#include "vec.h"

class checksum_string
{
public:
	uint16_t checksum; //0x0000
	char string[30]; //0x0002
}; //Size: 0x0020

class DisposeInfo
{
public:
	uint32_t N0000051D; //0x0000
	char pad_0004[4]; //0x0004
	uint64_t N0000051E; //0x0008
	uint32_t N0000051F; //0x0010
	uint32_t N000002CE; //0x0014
	uint32_t N00000520; //0x0018
	char pad_001C[4]; //0x001C
	uint32_t N00000521; //0x0020
	uint32_t N000002BF; //0x0024
	checksum_string modelName; //0x0028
	uint64_t N00000547; //0x0048
	uint64_t N00000548; //0x0050
	uint32_t N00000549; //0x0058
	uint32_t N000002D3; //0x005C
	uint16_t N0000054A; //0x0060
	int16_t N00004547; //0x0062
	uint8_t N00004545; //0x0064
	uint8_t N0000454A; //0x0065
	uint8_t fighterType; //0x0066
	uint8_t N0000454B; //0x0067
	uint8_t N0000054B; //0x0068
	uint8_t N00004552; //0x0069
	uint8_t N00004556; //0x006A
	char pad_006B[5]; //0x006B
	vec4f spawnPosition; //0x0070
	int16_t rotY; //0x0080
	char pad_0082[2]; //0x0082
	char battleStartAnim[32]; //0x0084
	int32_t N0000453C; //0x00A4
	uint16_t N0000453F; //0x00A8
	uint16_t N00004541; //0x00AA
}; //Size: 0x00AC