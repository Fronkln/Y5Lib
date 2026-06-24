#pragma once
#include "defines.h"
#include "OE.h"
#include "Objects/Class/CScenarioManager.h"

extern "C"
{
    Y5LIB_EXPORT inline void OE_LIB_CSCENARIOMANAGER_LOAD_PLAYER_POS(int playerPos, bool unk)
    {
        CScenarioManager* scenMan = *OE::ScenarioManager;

        if (scenMan == nullptr)
            return;

        scenMan->LoadPlayerPos(playerPos, unk);
    }

    Y5LIB_EXPORT inline void OE_LIB_CSCENARIOMANAGER_LOAD_SCENARIO(int scenarioID)
    {
        CScenarioManager* scenMan = *OE::ScenarioManager;

        if (scenMan == nullptr)
            return;

        scenMan->LoadScenario(scenarioID);
    }
}