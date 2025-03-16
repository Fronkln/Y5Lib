#pragma once
#include "defines.h"
#include "OE.h"
#include "CActionManager.h"


extern "C"
{
    Y5LIB_EXPORT inline unsigned int OE_LIB_ACTIONMANAGER_GETTER_UNPAUSED_TIME()
    {
        CActionManager* actMan = *OE::ActionManager;

        if (actMan == nullptr)
            return 0;

        return actMan->unpausedTime;
    }

    Y5LIB_EXPORT inline unsigned int OE_LIB_ACTIONMANAGER_GETTER_FULL_TIME()
    {
        CActionManager* actMan = *OE::ActionManager;

        if (actMan == nullptr)
            return 0;

        return actMan->totalTimeSinceStartup;
    }

    Y5LIB_EXPORT inline float OE_LIB_ACTIONMANAGER_GETTER_DELTA_TIME()
    {
        CActionManager* actMan = *OE::ActionManager;

        if (actMan == nullptr)
            return 0;

        return actMan->deltaTime;
    }

    Y5LIB_EXPORT inline float OE_LIB_ACTIONMANAGER_GETTER_FIXED_DELTA_TIME()
    {
        CActionManager* actMan = *OE::ActionManager;

        if (actMan == nullptr)
            return 0;

        return actMan->fixedDeltaTime;
    }

    Y5LIB_EXPORT inline bool OE_LIB_ACTIONMANAGER_GETTER_IS_LOADED()
    {
        CActionManager* actMan = *OE::ActionManager;

        if (actMan == nullptr)
            return false;

        return actMan->isLoaded;
    }

    Y5LIB_EXPORT inline bool OE_LIB_ACTIONMANAGER_GETTER_IS_PAUSED()
    {
        CActionManager* actMan = *OE::ActionManager;

        if (actMan == nullptr)
            return false;

        return actMan->gamePaused;
    }
}