#pragma once
#include "defines.h"
#include "CActionEntityManager.h"

extern "C"
{
	Y5LIB_EXPORT inline Entity* OE_LIB_ACTIONENTITYMANAGER_GET_ENTITY_BY_UID(int uid)
	{
		CActionEntityManager* entMan = *OE::ActionEntityManager;

		if (entMan == nullptr)
			return nullptr;

		return entMan->GetEntityByUID(uid);
	}
}