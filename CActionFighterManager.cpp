#include "CActionFighterManager.h"
#include "PatternScan.h"


CActionFighterManager::_AddToDisposeQueue CActionFighterManager::ASM_AddToDisposeQueue = (CActionFighterManager::_AddToDisposeQueue)(PatternScan("48 89 5C 24 08 48 89 74 24 10 57 48 83 EC ? 48 8B D9 48 8B F2 48 8B 89 A0 04 00 00"));
CActionFighterManager::_ProcessDisposeQueue CActionFighterManager::ASM_ProcessDisposeQueue = (CActionFighterManager::_ProcessDisposeQueue)(PatternScan("48 8B C4 57 41 54 41 55 41 56 41 57 48 81 EC ? ? ? ? 48 C7 44 24 20 ? ? ? ? 48 89 58 10 48 89 70 18"));