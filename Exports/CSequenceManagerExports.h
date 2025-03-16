#pragma once
#include "defines.h"
#include "OE.h"
#include "CSequenceManager.h"

extern "C"
{
    Y5LIB_EXPORT inline unsigned int OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->missionData->missionID;
    }
}