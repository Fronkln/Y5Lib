#pragma once
#include "defines.h"
#include "OE.h"
#include "CActionManager.h"
#include "Objects/Class/CActionHActCHPManager.h"

extern "C"
{
	Y5LIB_EXPORT inline const char* OE_LIB_HACTCHPMANAGER_GET_CURRENT()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionHActCHPManager == nullptr)
			return 0;

		return (const char*)&actMan->actionHActCHPManager->currentHAct.string;
	}
}