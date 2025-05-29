#pragma once
#include "defines.h"
#include "Objects/Class/CActionMotionManager.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{
	Y5LIB_EXPORT inline void OE_LIB_ACTIONMOTIONMANAGER_LOAD_GMT(unsigned int gmtID)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionMotionManager == nullptr)
			return;

		actMan->actionMotionManager->MotionManager.LoadGMTDirect(gmtID, 16, 6);
	}

	Y5LIB_EXPORT inline unsigned int OE_LIB_ACTIONMOTIONMANAGER_GET_GMT_ID(char* gmtName)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionMotionManager == nullptr)
			return 0;

		return actMan->actionMotionManager->fileProperty->GetGMTID(gmtName);
	}
}