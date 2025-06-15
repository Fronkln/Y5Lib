#pragma once
#include "defines.h"
#include "Objects/Class/CActionStageManager.h"
#include "CActionManager.h"
#include "OE.h"


extern "C"
{
	Y5LIB_EXPORT inline int OE_LIB_CACTIONSTAGEMANAGER_GETTER_STAGE_ID()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionStageManager == nullptr)
			return 0;

		return actMan->actionStageManager->stageID;
	}
}