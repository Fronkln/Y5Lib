#pragma once
#include "defines.h"
#include "Objects/Class/CActionHActManager.h"
#include "Objects/Class/CHAct.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{
	Y5LIB_EXPORT inline CHAct* OE_LIB_HACTMANAGER_GET_CURRENT()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionHActManager == nullptr)
			return 0;

		if (actMan->actionHActManager->currentHAct == nullptr)
			return 0;

		return actMan->actionHActManager->currentHAct->hact;
	}

	Y5LIB_EXPORT inline CHAct* OE_LIB_HACTMANAGER_GET_CURRENT_PRELOADED()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionHActManager == nullptr)
			return 0;

		if (actMan->actionHActManager->currentPreloadedHAct == nullptr)
			return 0;

		return actMan->actionHActManager->currentPreloadedHAct->hact;
	}

	Y5LIB_EXPORT inline int OE_LIB_HACTMANAGER_PRELOAD_HACT(const char* name, const char* path, int flags)
	{
		return CActionHActManager::ASM_PreloadHAct(name, path, flags);
	}

	Y5LIB_EXPORT inline void OE_LIB_HACTMANAGER_PLAY_HACT(int idx, int flags)
	{
		CActionHActManager::ASM_PlayHAct(idx ,flags);
	}
	Y5LIB_EXPORT inline void  OE_LIB_HACTMANAGER_REGISTER_FIGHTER_ON_HACT(int hactIdx, const char* replaceName, int fighterIndex, int unknown)
	{
		CActionHActManager::ASM_RegisterFighterOnHAct(hactIdx, replaceName, fighterIndex, unknown);
	}
}