#include "CActionMotionManager.h"
#include "MemoryMgr.h"

MOTIONMANAGER_LoadImportantResources CActionMotionManager::ASM_LoadImportantResources = (MOTIONMANAGER_LoadImportantResources)(PatternScan("41 56 48 83 EC ? 4C 8B F1 85 D2"));
MOTIONMANAGER_LoadGMTDirect MotionResourceManager::ASM_LoadGMTDirect = (MOTIONMANAGER_LoadGMTDirect)(PatternScan("48 89 5C 24 ? 48 89 74 24 ? 57 41 56 41 57 48 83 EC ? 48 8B F1"));
MOTIONRESOURCEMANAGER_LoadMotionPar MotionResourceManager::ASM_LoadPar = (MOTIONRESOURCEMANAGER_LoadMotionPar)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 90 48 89 BB ? ? ? ? 48 8D 8B ? ? ? ? 48 8D 05")));
MOTIONRESOURCEMANAGER_LoadMotionParToID MotionResourceManager::ASM_LoadParToID = (MOTIONRESOURCEMANAGER_LoadMotionParToID)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 89 9F ? ? ? ? 48 8B 8C 24")));
MOTIONRESOURCEMANAGER_LoadMotionParWithID MotionResourceManager::ASM_LoadParWithID = (MOTIONRESOURCEMANAGER_LoadMotionParWithID)(Memory::ReadCall2(PatternScan("E9 ? ? ? ? 48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24")));
MOTIONRESOURCEMANAGER_GetMotionParIDState MotionResourceManager::ASM_GetMotionParIDState = (MOTIONRESOURCEMANAGER_GetMotionParIDState)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 85 C0 75 ? 8D 50 ? EB ? 48 8B 0D")));
FILEMOTIONPROPERTY_GetGMTID CFileMotionProperty::ASM_GetGMTID = (FILEMOTIONPROPERTY_GetGMTID)(Memory::ReadCall2(PatternScan("E8 ? ? ? ? 89 87 ? ? ? ? 48 8D 9F")));