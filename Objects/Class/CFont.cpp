#include "CFont.h"
#include "MemoryMgr.h"

CFont::_PushText CFont::ASM_PushText = (CFont::_PushText)Memory::ReadCall2(PatternScan("E8 ? ? ? ? 48 8B 05 ? ? ? ? 48 39 B0"));