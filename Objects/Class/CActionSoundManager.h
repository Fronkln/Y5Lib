#pragma once
#include "CActionBase.h"


class CActionSoundManager : public CActionBase
{
	typedef void(__fastcall* _PlaySound)(int& in_sound_handle, int sound, int unknown);
public:
	static _PlaySound PlaySound;
};