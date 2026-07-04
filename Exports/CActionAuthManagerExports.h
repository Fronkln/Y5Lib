#pragma once
#include "defines.h"
#include "Objects/Class/CActionAuthManager.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{
	Y5LIB_EXPORT inline int OE_LIB_ACTIONAUTHMANAGER_GETTER_FLAGS()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionAuthManager == nullptr)
			return 0;

		return actMan->actionAuthManager->flags;
	}

	Y5LIB_EXPORT inline void OE_LIB_ACTIONAUTHMANAGER_SETTER_FLAGS(int flags)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionAuthManager == nullptr)
			return;

		actMan->actionAuthManager->flags = flags;
	}

	Y5LIB_EXPORT inline int OE_LIB_ACTIONAUTHMANAGER_GETTER_FLAGS2()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionAuthManager == nullptr)
			return 0;

		return actMan->actionAuthManager->flags2;
	}

	Y5LIB_EXPORT inline void OE_LIB_ACTIONAUTHMANAGER_SETTER_FLAGS2(int flags)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionAuthManager == nullptr)
			return;

		actMan->actionAuthManager->flags2 = flags;
	}
}