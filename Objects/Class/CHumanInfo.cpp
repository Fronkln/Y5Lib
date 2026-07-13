#pragma once
#include "CHumanInfo.h"
#include "MemoryMgr.h"

CHumanInfo::_get_human_info CHumanInfo::ASM_get_human_info  = (CHumanInfo::_get_human_info)Memory::ReadCall2(PatternScan("E8 ? ? ? ? 48 85 C0 74 ? 48 8B 40 ? F6 40"));