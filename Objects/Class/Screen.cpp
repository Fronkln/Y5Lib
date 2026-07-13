#include "Screen.h"
#include "PatternScan.h"
#include "MemoryMgr.h"

screen::_WorldToScreenPointRatio screen::ASM_WorldToScreenPointRatio = (screen::_WorldToScreenPointRatio)0x14144F750;
screen::_ScreenRatioToPixels screen::ASM_ScreenRatioToPixels = (screen::_ScreenRatioToPixels)PatternScan("40 53 48 83 EC ? 44 8B 05 ? ? ? ? 48 8B D9");