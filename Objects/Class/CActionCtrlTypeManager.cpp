#include "CActionCtrlTypeManager.h"
#include "PatternScan.h"

CACTIONCTRLTYPEMANAGER_SetBattlePhase CActionCtrlTypeManager::ASM_SetBattlePhase = (CACTIONCTRLTYPEMANAGER_SetBattlePhase)PatternScan("33 C0 85 D2 74 ? 83 FA");