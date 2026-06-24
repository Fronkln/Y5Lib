#pragma once
#include "DisposeInfo.h"

struct EnemyDisposeInfo
{
public:
	DisposeInfo Dispose;
	int32_t fighterIndex; //0x00B0
	char pad_00B4[12]; //0x00B4
};