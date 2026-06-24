#include "CActionFighterSyncManager.h"
#include "PatternScan.h"
#include "MemoryMgr.h"


CActionFighterSyncManager::_StartSync CActionFighterSyncManager::ASM_StartSync = (CActionFighterSyncManager::_StartSync)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 8B F8 83 F8 ? 0F 84 ? ? ? ? 66 41 83 7D")));