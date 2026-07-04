#pragma once
#include "defines.h"
#include "OE.h"
#include "Objects/Class/CActionSoundManager.h"

extern "C"
{
	Y5LIB_EXPORT inline int OE_LIB_ACTIONSOUNDMANAGER_PLAY_SOUND(short cuesheet, short soundID, int unknown)
	{
		int soundHandle;

		int sound = (int32_t)cuesheet << 16 | (int32_t)soundID;

		CActionSoundManager::PlaySound(soundHandle, sound, unknown);

		return soundHandle;
	}
}