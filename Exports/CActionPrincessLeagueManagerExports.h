#pragma once
#include "defines.h"
#include "Objects/Class/CActionPrincessLeagueManager.h"
#include "Objects/Class/CPrincessLeagueDancer.h"
#include "CActionManager.h"
#include "OE.h"

class Human;

extern "C"
{
	Y5LIB_EXPORT inline Human* OE_LIB_PRINCESSLEAGUEMANAGER_GET_PLAYER()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->princessLeagueManager == nullptr)
			return 0;

		if (actMan->princessLeagueManager->player == nullptr)
			return 0;

		return actMan->princessLeagueManager->player->dancer;
	}
}