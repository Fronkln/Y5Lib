#pragma once
#include "CActionBase.h"

class CCCCharacter
{
public:
	int32_t UID; //0x0000
	char pad_0004[140]; //0x0004
}; //Size: 0x0090


class CActionCCCManager : public CActionBase
{
public:
	char pad_01C8[120]; //0x01C8
	bool isActive; //0x0240
	char pad_0241[95]; //0x0241
	class N000044AC* activeCCC; //0x02A0
	char pad_02A8[40]; //0x02A8
	int32_t talkerUID; //0x02D0
	char pad_02D4[4]; //0x02D4
	void* N00003F56; //0x02D8
	int32_t playerUID; //0x02E0
	char pad_02E4[740]; //0x02E4
	int32_t characterCount; //0x05C8
	char pad_05CC[4]; //0x05CC
	class CCCCharacter characters[32]; //0x05D0
	char pad_17D0[7848]; //0x17D0
}; //Size: 0x3678