#pragma once
#include "defines.h"
#include "Objects/Class/CActionLiveBattleManager.h"
#include "Objects/Class/CDancer.h"
#include "CActionManager.h"
#include "OE.h"

class Human;

extern "C"
{
	Y5LIB_EXPORT inline Human* OE_LIB_LIVEBATTLEMANAGER_GET_PLAYER()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->liveBattleManager == nullptr)
			return 0;

		if (actMan->liveBattleManager->player == nullptr)
			return 0;

		return actMan->liveBattleManager->player->dancer;
	}
}