#pragma once
#include "defines.h"
#include "OE.h"	
#include "Objects/Struct/DisposeInfo.h"
#include "Objects/Class/Fighter.h"
#include "CSequenceManager.h"
#include "CActionManager.h"

extern "C"
{
	Y5LIB_EXPORT inline void OE_LIB_INIT()
	{
		OE::ActionFighterManager = (CActionFighterManager**)(resolve_relative_addr((PatternScan(GetModuleHandle(NULL), "48 8B 3D ? ? ? ? C5 F8 29 74 24 50")), 7));
		OE::ActionManager = (CActionManager**)(resolve_relative_addr((PatternScan(GetModuleHandle(NULL), "48 8B 05 ?? ?? ?? ?? 48 85 C0 74 ?? 48 8B 88 78 02 00 00 EB ?? 49 8B CC E8 ?? ?? ?? ?? 85 C0")), 7));
		OE::ActionEntityManager = (CActionEntityManager**)(resolve_relative_addr((PatternScan(GetModuleHandle(NULL), "48 8B 0D ? ? ? ? E8 ? ? ? ? 48 8B 07 48 8B CF FF 50 08 E9 ? ? ? ?")), 7));
		OE::SequenceManager = (CSequenceManager**)(resolve_relative_addr((PatternScan(GetModuleHandle(NULL), "48 8B 05 ? ? ? ? 44 8B 88 88 00 00 00")), 7));

		OE::InitHook();
	}

	Y5LIB_EXPORT inline bool OE_LIB_IS_INIT()
	{
		if (OE::SequenceManager == nullptr)
			return false;

		CSequenceManager* seqMan = *OE::SequenceManager;
		
		if (seqMan == nullptr || seqMan->missionData == nullptr)
			return false;

		return (*OE::ActionManager)->isLoaded && seqMan->missionData->missionID > 0 && seqMan->missionData->missionID < 1500;
	}

	Y5LIB_EXPORT inline void OE_LIB_TEST(DisposeInfo* disp)
	{

	}

	Y5LIB_EXPORT inline void OE_LIB_REGISTER_JOB(_OE_RegisterJob funcPointer, int jobPhase, bool after)
	{
		OE::RegisterJob(funcPointer, jobPhase, after);
	}

	Y5LIB_EXPORT inline void OE_LIB_UNREGISTER_JOB(void* func, int phase)
	{
		OE::UnregisterJob(func, phase);
		std::cout << "Job unregistered." << std::endl;
	}
}