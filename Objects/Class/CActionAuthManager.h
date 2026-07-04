#pragma once
#include "CActionBase.h"

class CActionAuthManager : public CActionBase
{
public:
	int32_t N00005C46; //0x01C8
	int32_t flags; //0x01CC
	char pad_01D0[140]; //0x01D0
	int32_t flags2; //0x025C
	char pad_0260[8]; //0x0260
}; //Size: 0x0268