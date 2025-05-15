#include "CActionHActManager.h"
#include "PatternScan.h"

HACTMANAGER_PreloadHAct CActionHActManager::ASM_PreloadHAct = (HACTMANAGER_PreloadHAct)PatternScan("48 8B C4 57 41 54 41 55 41 56 41 57 48 83 EC ? 48 C7 40 ? ? ? ? ? 48 89 58 ? 48 89 68 ? 48 89 70 ? 45 8B E0");
HACTMANAGER_PlayHAct CActionHActManager::ASM_PlayHAct = (HACTMANAGER_PlayHAct)PatternScan("48 89 5C 24 ? 57 48 83 EC ? 8B FA E8 ? ? ? ? 48 8B D8 48 85 C0 74");
HACTMANAGER_RegisterFighterOnHAct CActionHActManager::ASM_RegisterFighterOnHAct = (HACTMANAGER_RegisterFighterOnHAct)PatternScan("48 89 5C 24 08 48 89 74 24 10 57 48 83 EC ? 41 8B F1 41 8B F8 48 8B DA");