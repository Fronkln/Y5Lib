#pragma once
#include "defines.h"
#include "Objects/Class/CActionDanceBattleManager.h"
#include "Objects/Class/CActionDanceEventManager.h"
#include "CActionManager.h"
#include "OE.h"

class Human;

extern "C"
{
	Y5LIB_EXPORT inline Human* OE_LIB_DANCEBATTLEMANAGER_GET_DANCER(int idx)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->danceBattleManager == nullptr)
			return 0;

		if (actMan->danceBattleManager->dancers[idx] == nullptr)
			return 0;

		return actMan->danceBattleManager->dancers[idx]->dancer;
	}

	Y5LIB_EXPORT inline Human* OE_LIB_DANCEEVENTMANAGER_GET_PLAYER()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->danceEventManager == nullptr)
			return 0;

		if (actMan->danceEventManager->player == nullptr)
			return 0;

		return actMan->danceEventManager->player->dancer;
	}
}