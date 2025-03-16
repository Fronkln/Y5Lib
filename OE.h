#pragma once
#include <Windows.h>
#include <vector>
#include "Hook/MinHook.h"

#pragma comment(lib, "Hook/libMinHook.x64.lib")

class CActionFighterManager;
class CActionManager;
class CActionEntityManager;
class CSequenceManager;

typedef void(__cdecl* _OE_RegisterJob)();
typedef void(__cdecl* _OE_CJob_Phase_Execute)(int job);


class OE
{
    struct JobInfo
    {
        _OE_RegisterJob funcAddress;
        unsigned int phase;
        bool after;
    };

    static bool m_hookInit;

    static std::vector<JobInfo> m_registeredJobsPre;
    static std::vector<JobInfo> m_registeredJobsAfter;
    static _OE_CJob_Phase_Execute phase_execute_trampoline;


    static void Hook_JobPhaseExecute(unsigned int phase)
    {
        //make this code more efficie

        for (auto& jobReg : m_registeredJobsPre) // access by reference to avoid copying
        {
            if (jobReg.phase == phase)
                jobReg.funcAddress(); //call the function, we are at the phase
        }

        phase_execute_trampoline(phase);

        for (auto& jobReg : m_registeredJobsAfter) // access by reference to avoid copying
        {
            if (jobReg.phase == phase)
                jobReg.funcAddress(); //call the function, we are at the phase
        }

    }
public:
    static void RegisterJob(_OE_RegisterJob job, int jobPhase, bool after)
    {
        JobInfo newJob = JobInfo();
        newJob.funcAddress = job;
        newJob.phase = jobPhase;
        newJob.after = after;

        if (!after)
            m_registeredJobsPre.push_back(newJob);
        else
            m_registeredJobsAfter.push_back(newJob);
    };

    static void UnregisterJob(void* jobDel, int phase)
    {
        m_registeredJobsPre.erase(
            std::remove_if(
                m_registeredJobsPre.begin(),
                m_registeredJobsPre.end(),
                [&](JobInfo const& job) { return job.phase == phase && job.funcAddress == jobDel; }
            ),
            m_registeredJobsPre.end()
        );

        m_registeredJobsAfter.erase(
            std::remove_if(
                m_registeredJobsAfter.begin(),
                m_registeredJobsAfter.end(),
                [&](JobInfo const& job) { return job.phase == phase && job.funcAddress == jobDel; }
            ),
            m_registeredJobsAfter.end()
        );
    };

	static CActionFighterManager** ActionFighterManager;
    static CActionManager** ActionManager;
    static CActionEntityManager** ActionEntityManager;
    static CSequenceManager** SequenceManager;

    static void InitHook()
    {
        if (m_hookInit)
            return;

        MH_Initialize();

        void* updateFunc = PatternScan("89 4C 24 08 53 55 56 57 41 54 41 55 41 56 41 57 48 83 EC ? 8B 15 ? ? ? ?");

        MH_STATUS phaseHookStatus = MH_CreateHook(reinterpret_cast<void**>(updateFunc), &Hook_JobPhaseExecute, reinterpret_cast<void**>(&phase_execute_trampoline));
        MH_EnableHook(reinterpret_cast<void**>(updateFunc));

        m_hookInit = true;
    }
};

