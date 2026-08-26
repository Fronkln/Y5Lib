#pragma once
#pragma once
#include "defines.h"
#include "Objects/Class/CActionEnemyDisposeManager.h"
#include "CActionManager.h"
#include "OE.h"

extern "C"
{

	Y5LIB_EXPORT inline char* OE_LIB_ACTIONENCOUNTMANAGER_GET_START_HACT()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->enemyDisposeManager == nullptr)
			return 0;

		auto ptr = (char*)actMan->enemyDisposeManager->startHAct;
		return ptr;
	}
	Y5LIB_EXPORT inline void OE_LIB_ACTIONENCOUNTMANAGER_SET_START_HACT(const char* hact)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return;

		if (actMan->enemyDisposeManager == nullptr)
			return;

		strcpy_s(actMan->enemyDisposeManager->startHAct, 30, hact);
	}

	Y5LIB_EXPORT inline int OE_LIB_ACTIONENCOUNTMANAGER_ADD_ENEMY_DISPOSE(EnemyDisposeInfo* enemyDispose)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		auto enemyDisposeManager = actMan->enemyDisposeManager;

		if (enemyDisposeManager == nullptr)
			return 0;

		memcpy_s((void*)&enemyDisposeManager->enemyDisposesStart[enemyDisposeManager->enemyDisposesCount], 192, enemyDispose, 192);
		enemyDisposeManager->enemyDisposesCount++;

		return enemyDisposeManager->enemyDisposesCount;
	}


	Y5LIB_EXPORT inline int OE_LIB_ACTIONENCOUNTMANAGER_GET_ENEMY_COUNT(EnemyDisposeInfo* enemyDispose)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		auto enemyDisposeManager = actMan->enemyDisposeManager;

		if (enemyDisposeManager == nullptr)
			return 0;

		return enemyDisposeManager->enemyDisposesCount;
	}

	Y5LIB_EXPORT inline EnemyDisposeInfo* OE_LIB_ACTIONENCOUNTMANAGER_GET_ENEMY_DISPOSE(int enemyIndex)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		int test = sizeof(DisposeInfo);

		auto enemyDisposeManager = actMan->enemyDisposeManager;

		if (enemyDisposeManager == nullptr)
			return 0;

		return &enemyDisposeManager->enemyDisposes[enemyIndex];
	}
}