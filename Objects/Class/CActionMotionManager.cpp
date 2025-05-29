#include "CActionMotionManager.h"
#include "MemoryMgr.h"

MOTIONMANAGER_LoadGMTDirect MotionManager::ASM_LoadGMTDirect = (MOTIONMANAGER_LoadGMTDirect)(PatternScan("48 89 5C 24 ? 48 89 74 24 ? 57 41 56 41 57 48 83 EC ? 48 8B F1"));
FILEMOTIONPROPERTY_GetGMTID CFileMotionProperty::ASM_GetGMTID = (FILEMOTIONPROPERTY_GetGMTID)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 89 87 ? ? ? ? 48 8D 9F")));