#pragma once
#include "defines.h"
#include "Objects/Class/criAdx2Player.h"

extern "C"
{
	Y5LIB_EXPORT void OE_LIB_CRIADX2PLAYER_RESUME(criAdx2Player* player)
	{
		if (player == nullptr)
			return;

		player->Resume();
	}

	Y5LIB_EXPORT void OE_LIB_CRIADX2PLAYER_PAUSE(criAdx2Player* player)
	{
		if (player == nullptr)
			return;

		player->Pause();
	}

	Y5LIB_EXPORT bool OE_LIB_CRIADX2PLAYER_IS_PAUSED(criAdx2Player* player)
	{
		if (player == nullptr)
			return false;

		return player->IsPaused();
	}

	Y5LIB_EXPORT void OE_LIB_CRIADX2PLAYER_SET_START_TIME(criAdx2Player* player, int time)
	{
		if (player == nullptr)
			return;

		player->SetStartTime(time);
	}

	Y5LIB_EXPORT void OE_LIB_CRIADX2PLAYER_START_STREAM(criAdx2Player* player, const char* stream)
	{
		if (player == nullptr)
			return;

		player->StartStream(stream);
	}


	Y5LIB_EXPORT void OE_LIB_CRIADX2PLAYER_START(criAdx2Player* player)
	{
		if (player == nullptr)
			return;

		player->Start();
	}

	Y5LIB_EXPORT void OE_LIB_CRIADX2PLAYER_STOP_WITHOUT_RELEASE_TIME(criAdx2Player* player)
	{
		if (player == nullptr)
			return;

		player->StopWithoutReleaseTime();
	}
}