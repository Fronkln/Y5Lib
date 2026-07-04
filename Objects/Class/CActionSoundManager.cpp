#include "CActionSoundManager.h"
#include "PatternScan.h"
#include "MemoryMgr.h"

CActionSoundManager::_PlaySound CActionSoundManager::PlaySound = (CActionSoundManager::_PlaySound)Memory::ReadCall2(PatternScan(" E8 ? ? ? ? E9 ? ? ? ? 48 8B 8E ? ? ? ? E8 ? ? ? ? 48 63 8C 9E"));