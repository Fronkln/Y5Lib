#pragma once
#include "defines.h"
#include "OE.h"
#include "Objects/Class/CSequenceManager.h"

extern "C"
{
    Y5LIB_EXPORT inline void* OE_LIB_SEQUENCEMANAGER_GETTER_SEQUENCECOMMANDDEF()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->sequenceCommandDef;
    }

    Y5LIB_EXPORT inline void* OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION_DATA()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->missionData;
    }

    Y5LIB_EXPORT inline unsigned int OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->missionData->missionID;
    }

    Y5LIB_EXPORT inline int OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_STAGE_ID()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->missionData->stageID;
    }

    Y5LIB_EXPORT inline int OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_UNKNOWN_MODE()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return 0;

        return seqMan->missionData->someMode;
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

    Y5LIB_EXPORT inline int OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_STAGE_ID()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return 0;

        return seqMan->nextMissionData->stageID;
    }

    Y5LIB_EXPORT inline int OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_UNKNOWN_MODE()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return 0;

        return seqMan->nextMissionData->someMode;
    }

    Y5LIB_EXPORT inline vec4f OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_PLAYER_POSITION()
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr || seqMan->nextMissionData == nullptr)
            return vec3f();

        return seqMan->nextMissionData->playerPosition;
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

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_ID(unsigned int mission)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return;

        seqMan->nextMissionData->missionID = mission;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_SCENARIO_ID(unsigned int scenario)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return;

        seqMan->nextMissionData->scenarioID = scenario;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_STAGE(int stage)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return;

        seqMan->nextMissionData->stageID = stage;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_UNKNOWN_MODE(int mode)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return;

        seqMan->nextMissionData->someMode = mode;
    }

    Y5LIB_EXPORT inline void OE_LIB_SEQUENCEMANAGER_SET_NEXT_PLAYER_POSITION(vec3f position)
    {
        CSequenceManager* seqMan = *OE::SequenceManager;

        if (seqMan == nullptr)
            return;

        seqMan->nextMissionData->playerPosition = position;
    }
}