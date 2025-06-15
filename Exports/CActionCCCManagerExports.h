#pragma once
#include "defines.h"
#include "Objects/Class/CActionCCCManager.h"
#include "CActionManager.h"
#include "OE.h"


extern "C"
{
	Y5LIB_EXPORT inline bool OE_LIB_CACTIONCCCMANAGER_GETTER_IS_ACTIVE()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->cccManager == nullptr)
			return 0;

		return actMan->cccManager->isActive;
	}
}