#include "FighterMode.h"
#include "PatternScan.h"

FIGHTERMODEMANAGER_SetCommandSet FighterModeManager::ASM_SetCommandset = (FIGHTERMODEMANAGER_SetCommandSet)PatternScan("48 89 5C 24 ? 48 89 74 24 ? 57 48 83 EC ? 48 63 F2 48 8B F9 48 8B 0D");