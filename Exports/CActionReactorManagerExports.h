#pragma once
#include "defines.h"
#include "Objects/Class/CActionReactorManager.h"
#include "CActionManager.h"
#include "OE.h"


extern "C"
{
	Y5LIB_EXPORT inline Entity* OE_LIB_ACTIONREACTORMANAGER_CREATEREACTOR(const char* name, vec4f pos, vec4f rot)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->reactorManager == nullptr)
			return 0;

		vec4f idk = vec4f(1, 1, 1, 1);
		vec4f idk2;

		Entity* reactor = actMan->reactorManager->CreateReactor(name, &pos, &rot, &idk, &idk2, 0, 0, -1);
		return reactor;
	}
}