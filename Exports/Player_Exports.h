#pragma once
#include "defines.h"
#include "Objects/Class/Player.h"

class CInputDeviceSlot;

extern "C"
{
	Y5LIB_EXPORT inline int OE_LIB_PLAYER_GET_CURRENT_ID(int slot)
	{
		return Player::GetCurrentID();
	}
}