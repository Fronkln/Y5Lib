#include "CActionCCCManager.h"

CActionCCCManager::_PlayCCC CActionCCCManager::ASM_PlayCCC = (CActionCCCManager::_PlayCCC)PatternScan("48 8B C4 55 57 41 54 41 56 41 57 48 8B EC 48 81 EC");
CActionCCCManager::_GetEntityData CActionCCCManager::ASM_GetEntityData = (CActionCCCManager::_GetEntityData)PatternScan("48 8B 01 45 33 C0 4C 8B D9");