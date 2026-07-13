#pragma once
#include "defines.h"
#include "OE.h"
#include "CActionFighterManager.h"

extern "C"
{
	Y5LIB_EXPORT inline SyncRegisterData* OE_LIB_ACTIONFIGHTERSYNCMANAGER_GET_DATA_BY_SERIAL(int serial)
	{
		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return 0;

		for (int i = 0; i < fman->fighterSyncManager.activeSyncs; i++)
		{
			auto syncData = fman->fighterSyncManager.activeSyncDatas[i];

			if (syncData->serial == serial)
				return syncData;
		}

		return nullptr;
	}

	Y5LIB_EXPORT inline FighterCommandID OE_LIB_SYNCREGISTERDATA_GETTER_COMMAND(SyncRegisterData* registerDat)
	{
		if (registerDat == nullptr)
			return FighterCommandID();

		return registerDat->command;
	}

	Y5LIB_EXPORT inline int OE_LIB_SYNCREGISTERDATA_GETTER_PAIR_COUNT(SyncRegisterData* registerDat)
	{
		if (registerDat == nullptr)
			return -1;

		return registerDat->pairCount;
	}

	Y5LIB_EXPORT inline int OE_LIB_SYNCREGISTERDATA_GET_PAIR_FIGHTER_INDEX(SyncRegisterData* registerDat, int index)
	{
		if (registerDat == nullptr || index < 0 || index >= registerDat->pairCount)
			return -1;

		return registerDat->syncPairs[index].fighterIndex;
	}

	Y5LIB_EXPORT inline SyncRegisterData* OE_LIB_ACTIONFIGHTERSYNCMANAGER_GET_SYNCTOMAKE_BY_SERIAL(int serial)
	{
		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return 0;

		auto syncMan = fman->fighterSyncManager;

		for (int i = 0; i < syncMan.syncsToMake; i++)
			if (syncMan.syncsToMakeDataPtr[i]->serial == serial)
				return syncMan.syncsToMakeDataPtr[i];

		return nullptr;
	}

	Y5LIB_EXPORT inline SyncRegisterData* OE_LIB_ACTIONFIGHTERSYNCMANAGER_GET_SYNCTOMAKE(int idx)
	{
		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return 0;

		if (idx >= fman->fighterSyncManager.syncsToMake)
			return nullptr;

		return fman->fighterSyncManager.syncsToMakeDataPtr[idx];
	}

	Y5LIB_EXPORT inline int OE_LIB_ACTIONFIGHTERSYNCMANAGER_GETTER_SYNCSTOMAKE(FighterCommandID command, int initiatorIdx, int targetIdx)
	{
		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return 0;

		return fman->fighterSyncManager.syncsToMake;
	}

	Y5LIB_EXPORT inline int OE_LIB_ACTIONFIGHTERSYNCMANAGER_START_SYNC(FighterCommandID command, int initiatorIdx, int targetIdx)
	{

		CActionFighterManager* fman = *OE::ActionFighterManager;

		if (fman == nullptr)
			return 0;

		return fman->fighterSyncManager.StartSync(command, initiatorIdx, targetIdx);
	}
}