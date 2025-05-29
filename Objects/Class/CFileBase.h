#pragma once
#include <cstdint>
class CFileBase
{
public:
	void* vfptr; //0x0000
	int16_t N0000277E; //0x0008
	int16_t N000027DC; //0x000A
	char pad_000C[2]; //0x000C
	char fullPath[256]; //0x000E
	char pad_010E[6]; //0x010E
	uint32_t someFlag; //0x0114
	char* fileName; //0x0118
	char* relativePath2; //0x0120
	char pad_0128[8]; //0x0128
	void* buffer; //0x0130
	char pad_0138[16]; //0x0138
}; //Size: 0x0148