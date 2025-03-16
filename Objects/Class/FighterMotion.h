#pragma once
#include "HumanMotion.h"

namespace Motion
{
	class FighterMotion : public Motion::HumanMotion
	{
	public:
		char pad_10A0[192]; //0x10A0
	}; //Size: 0x1160
}