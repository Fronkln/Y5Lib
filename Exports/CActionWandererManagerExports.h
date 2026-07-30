#pragma once
#include "defines.h"
#include "Objects/Class/CActionWandererManager.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{
	Y5LIB_EXPORT Wanderer* OE_LIB_ACTIONWANDERERMANAGER_CREATE_WANDERER(CCCEntityEntry* entry)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionWandererManager == nullptr)
			return 0;

		return (Wanderer*)actMan->actionWandererManager->CreateEntity(entry);
	}

	Y5LIB_EXPORT bool OE_LIB_ACTIONWANDERERMANAGER_DESTROY_WANDERER(Wanderer* wanderer)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionWandererManager == nullptr)
			return 0;
		
		actMan->actionWandererManager->DestroyEntity(wanderer);
	}
}