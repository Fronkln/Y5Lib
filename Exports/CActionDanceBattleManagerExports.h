#pragma once
#include "defines.h"
#include "Objects/Class/CActionDanceBattleManager.h"
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
}