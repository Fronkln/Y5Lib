#pragma once
#include "defines.h"
#include "OE.h"
#include "Objects/Class/CSequenceManager.h"

extern "C"
{
    Y5LIB_EXPORT inline unsigned int OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->missionData->missionID;
    }

    Y5LIB_EXPORT inline unsigned int OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_MISSION()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->nextMissionData->missionID;
    }

    Y5LIB_EXPORT inline unsigned int OE_LIB_SEQUENCEMANAGER_GETTER_SEQUENCE_PHASE()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->sequencePhase;
    }

    Y5LIB_EXPORT inline bool OE_LIB_SEQUENCEMANAGER_GETTER_IS_LOADING()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return false;

        return seqMan->isLoading;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_ID(unsigned int missionID)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return;

        seqMan->nextMissionData->missionID = missionID;
    }

    Y5LIB_EXPORT inline int OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION_SCENARIO()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->missionData == nullptr)
            return 0;

        return seqMan->missionData->scenarioID;
    }

    Y5LIB_EXPORT inline int OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_MISSION_SCENARIO()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return 0;

        return seqMan->nextMissionData->scenarioID;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_SCENARIO(unsigned int scenarioID)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return;

        seqMan->nextMissionData->scenarioID = scenarioID;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_START_TYPE(int startType)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return;

        seqMan->nextMissionData->startType = startType;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_START_HACT(const char* startHAct)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return;

        seqMan->nextMissionData->startHAct.set(startHAct);
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_LOAD_NEXT_MISSION()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return;

        CSequenceManager::LoadNextMission();
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_ALLOW_MISSION_TRANSITION(bool allow)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->missionData == nullptr)
            return;

        seqMan->missionData->prohibitTransition = !allow;
    }
}