// Created with ReClass.NET 1.2 by KN4CK3R
#pragma once
#include <stdint.h>
#include "vec.h"

class checksum_string
{
public:
	uint16_t checksum; //0x0000
	char string[30]; //0x0002
}; //Size: 0x0020

#pragma pack(1)
class DisposeInfo
{
public:
	uint32_t N0000051D; //0x0000
	int16_t N000002C1; //0x0004
	int16_t N00001F51; //0x0006
	uint64_t N0000051E; //0x0008
	uint32_t N0000051F; //0x0010
	uint32_t N000002CE; //0x0014
	uint32_t N00000520; //0x0018
	uint32_t N000002BD; //0x001C
	uint32_t N00000521; //0x0020
	uint32_t N000002BF; //0x0024
	checksum_string modelName; //0x0028
	uint64_t N00000547; //0x0048
	uint64_t N00000548; //0x0050
	uint32_t N00000549; //0x0058
	uint32_t N000002D3; //0x005C
	uint16_t N0000054A; //0x0060
	int16_t height; //0x0062
	uint8_t N00004545; //0x0064
	uint8_t voicerID; //0x0065
	uint8_t fighterType; //0x0066
	uint8_t damage; //0x0067
	uint8_t voicerID2; //0x0068
	uint8_t N00004552; //0x0069
	uint8_t N00004556; //0x006A
	uint16_t N0000455D; //0x006B
	uint16_t N00003ED8; //0x006D
	uint8_t N00004554; //0x006F
	vec4f spawnPosition; //0x0070
	uint32_t rotY; //0x0080
	char battleStartAnim[32]; //0x0084
	int32_t fighterUID; //0x00A4
	uint16_t N0000453F; //0x00A8
	uint16_t N00004541; //0x00AA
	char pad_00AC[4]; //0x00AC
}; //Size: 0x00B0
#pragma pack(pop)