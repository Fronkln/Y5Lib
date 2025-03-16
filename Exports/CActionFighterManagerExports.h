#pragma once
#include "defines.h"
#include "OE.h"
#include "CActionFighterManager.h"


extern "C"
{
	Y5LIB_EXPORT inline Fighter* OE_LIB_ACTIONFIGHTERMANAGER_GET_FIGHTER(int index)
	{
		if (index == -1)
			return nullptr;

		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return nullptr;

		return fman->GetFighter(index);
	}

	Y5LIB_EXPORT inline bool OE_LIB_ACTIONFIGHTERMANAGER_IS_FIGHTER_PRESENT(int index)
	{
		if (index == -1)
			return false;

		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return false;

		return (fman->presentFighters & (static_cast<unsigned long long>(1) << 63 - index)) != 0;
	}

	Y5LIB_EXPORT inline void OE_LIB_ACTIONFIGHTERMANAGER_DESTROY_FIGHTER(int index)
	{
		if (index == -1)
			return;

		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return;

		unsigned long long val = (static_cast<unsigned long long>(1) << 63 - index);
		fman->fightersToDestroy |= val;
	}

	Y5LIB_EXPORT inline Fighter* OE_LIB_ACTIONFIGHTERMANAGER_GET_PLAYER()
	{
		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return nullptr;

		if (fman->playerIdx < 0)
			return 0;

		return fman->GetFighter(fman->playerIdx);
	}


	Y5LIB_EXPORT inline void OE_LIB_ACTIONFIGHTERMANAGER_SET_PLAYER(int idx)
	{
		if (idx < 0)
			return;

		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return;

		fman->playerIdx = idx;
	}

	Y5LIB_EXPORT inline int OE_LIB_ACTIONFIGHTERMANAGER_ADD_TO_DISPOSE_QUEUE(DisposeInfo* inf)
	{
		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return -1;

		int id = fman->AddToDisposeQueue(inf);

		return id;
	}
}