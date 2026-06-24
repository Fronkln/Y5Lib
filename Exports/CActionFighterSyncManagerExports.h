#pragma once
#include "defines.h"
#include "OE.h"
#include "CActionFighterManager.h"

extern "C"
{
	Y5LIB_EXPORT inline int OE_LIB_ACTIONFIGHTERSYNCMANAGER_START_SYNC(FighterCommandID command, int initiatorIdx, int targetIdx)
	{

		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return 0;

		return fman->fighterSyncManager.StartSync(command, initiatorIdx, targetIdx);
	}
}