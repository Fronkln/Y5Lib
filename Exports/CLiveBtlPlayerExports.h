#pragma once
#include "defines.h"
#include "Objects/Class/CLiveBtlPlayer.h"

extern "C"
{
	Y5LIB_EXPORT inline CLiveBtlPlayer* OE_LIB_LIVEBTLPLAYER_GET_CURRENT()
	{
		return *CLiveBtlPlayer::Current;
	}
}