#include "FighterCommandManager.h"
#include "PatternScan.h"

FighterCommandManager::_GetCommandInfo FighterCommandManager::GetCommandInfo = (FighterCommandManager::_GetCommandInfo)PatternScan("8B 01 48 8B 0D ? ? ? ? 44 0F B7 D0");