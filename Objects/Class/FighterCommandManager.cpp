#include "FighterCommandManager.h"
#include "PatternScan.h"

FighterCommandManager::_GetCommandInfo FighterCommandManager::GetCommandInfo = (FighterCommandManager::_GetCommandInfo)PatternScan("8B 01 48 8B 0D ? ? ? ? 44 0F B7 D0");
FighterCommandManager::_FindCommandsetID  FighterCommandManager::ASM_FindCommandsetID = (FighterCommandManager::_FindCommandsetID)PatternScan("40 53 48 83 EC ? 48 8B DA E8 ? ? ? ? B8");

FighterCommandManager** FighterCommandManager::Instance = (FighterCommandManager**)resolve_relative_addr(PatternScan("48 8B 0D ? ? ? ? 48 8D 54 24 ? E8 ? ? ? ? 8B 5C 24"), 7);