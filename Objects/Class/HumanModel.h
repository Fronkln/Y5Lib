#pragma once
#include "pch.h"

class HumanModel
{
public:
	void* vfptr; //0x0000
	char pad_0008[56]; //0x0008
	class pxd_hash modelName; //0x0040
	class pxd_hash modelName2; //0x0060
	char pad_0080[952]; //0x0080
}; //Size: 0x0438
