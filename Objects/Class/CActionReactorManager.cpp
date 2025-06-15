#include "CActionReactorManager.h"
#include "MemoryMgr.h"

REACTORMANAGER_CreateReactor CActionReactorManager::ASM_CreateReactor = (REACTORMANAGER_CreateReactor)(PatternScan("40 53 48 81 EC ? ? ? ? 48 8B 84 24 ? ? ? ? 48 8B D9 48 8B CA"));
REACTORMANAGER_FindReactorID  CActionReactorManager::ASM_FindReactorID = (REACTORMANAGER_FindReactorID)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 8B D0 4C 8D 4C 24")));