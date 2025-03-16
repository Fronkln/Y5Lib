#include "pch.h"
#include "OE.h"

std::vector<OE::JobInfo> OE::m_registeredJobsPre;
std::vector<OE::JobInfo> OE::m_registeredJobsAfter;
_OE_CJob_Phase_Execute OE::phase_execute_trampoline;

bool OE::m_hookInit = false;

CActionFighterManager** OE::ActionFighterManager;
CActionManager** OE::ActionManager;
CActionEntityManager** OE::ActionEntityManager;
CSequenceManager** OE::SequenceManager;