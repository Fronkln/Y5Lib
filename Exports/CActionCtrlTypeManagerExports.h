#pragma once
#include "defines.h"
#include "Objects/Class/CActionCtrlTypeManager.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{
	Y5LIB_EXPORT inline int OE_LIB_CACTIONCTRLTYPEMANAGER_GETTER_START_TYPE()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->controlTypeManager == nullptr)
			return 0;

		return actMan->controlTypeManager->battleStartType;
	}


	Y5LIB_EXPORT inline int OE_LIB_CACTIONCTRLTYPEMANAGER_GETTER_BATTLE_PHASE()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->controlTypeManager == nullptr)
			return 0;

		return actMan->controlTypeManager->battlePhase;
	}

	Y5LIB_EXPORT inline int OE_LIB_CACTIONCTRLTYPEMANAGER_GETTER_BATTLE_SUB_PHASE()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->controlTypeManager == nullptr)
			return 0;

		return actMan->controlTypeManager->battleSubPhase;
	}

	Y5LIB_EXPORT inline void OE_LIB_CACTIONCTRLTYPEMANAGER_ALLOW_PHASE_PROGRESS()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->controlTypeManager == nullptr)
			return;

		actMan->controlTypeManager->allowPhaseProgress = 1;
	}

	Y5LIB_EXPORT inline void OE_LIB_CACTIONCTRLTYPEMANAGER_SET_BATTLE_PHASE(int phase)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->controlTypeManager == nullptr)
			return;

		actMan->controlTypeManager->SetBattlePhase(phase);
	}
}