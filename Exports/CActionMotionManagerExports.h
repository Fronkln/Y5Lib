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

		actMan->actionMotionManager->MotionResourceManager.LoadGMTDirect(gmtID, 16, 6);
	}

	Y5LIB_EXPORT inline void OE_LIB_ACTIONMOTIONMANAGER_LOAD_PAR(char* path)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionMotionManager == nullptr)
			return;

		actMan->actionMotionManager->MotionResourceManager.LoadPar(path, 6, 0xD, 1, 1, -2);
	}

	Y5LIB_EXPORT inline void OE_LIB_ACTIONMOTIONMANAGER_LOAD_PAR_TO_ID(char* path, int id)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionMotionManager == nullptr)
			return;

		actMan->actionMotionManager->MotionResourceManager.LoadParToID(path, id, 1, 1);
	}

	Y5LIB_EXPORT inline void OE_LIB_ACTIONMOTIONMANAGER_LOAD_PAR_WITH_ID(int id, int a2)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionMotionManager == nullptr)
			return;

		actMan->actionMotionManager->MotionResourceManager.LoadParWithID(id, a2);
	}

	Y5LIB_EXPORT inline int OE_LIB_ACTIONMOTIONMANAGER_GET_MOTION_PAR_ID_STATE(int id)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionMotionManager == nullptr)
			return 0;

		return actMan->actionMotionManager->MotionResourceManager.GetMotionParIDState(id);
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


	Y5LIB_EXPORT inline void OE_LIB_ACTIONMOTIONMANAGER_LOAD_IMPORTANT_RESOURCES(bool isBattle)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->actionMotionManager == nullptr)
			return;

		actMan->actionMotionManager->LoadImportantResources(isBattle);
	}

}