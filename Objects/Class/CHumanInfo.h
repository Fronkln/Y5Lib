#pragma once
#include "pch.h"


class HumanInfo
{
public:
	int16_t infoID; //0x0000
	int16_t faceModel; //0x0002
	int16_t topModel; //0x0004
	int16_t bottomModel; //0x0006
	int16_t hairModel; //0x0008
	char pad_000A[6]; //0x000A
	uint8_t heightIndex; //0x0010
	int8_t type; //0x0011
	int8_t charaID; //0x0012
	uint8_t motionSet; //0x0013
	char pad_0014[20]; //0x0014
}; //Size: 0x0028

class CHumanInfo
{
	typedef CHumanInfo*(__fastcall* _get_human_info)(pxd_hash* human_name);

	static _get_human_info ASM_get_human_info;

public:
	void* vfptr; //0x0000
	char pad_0008[56]; //0x0008
	class pxd_hash characterName; //0x0040
	HumanInfo* humanInfoData; //0x0060

	static CHumanInfo* get_human_info(pxd_hash* human_name)
	{
		return ASM_get_human_info(human_name);
	}
}; //Size: 0x0068