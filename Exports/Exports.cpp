#pragma once
#include "LibraryExports.h"
#include "EntityExports.h"
#include "CCameraBaseExports.h"
#include "HumanExports.h"
#include "FighterExports.h"
#include "FighterModeExports.h"
#include "MotionExports.h"
#include "CHActExports.h"
#include "CActionManagerExports.h"
#include "CActionFighterManagerExports.h"
#include "CActionMotionManagerExports.h"
#include "CActionEntityManagerExports.h"
#include "CActionCameraManagerExports.h"
#include "CActionReactorManagerExports.h"
#include "CActionHActManagerExports.h"
#include "CSequenceManagerExports.h"
#include "CLiveBtlPlayerExports.h"
#include "CActionLiveBattleManagerExports.h"
#include "CActionPrincessLeagueManagerExports.h"
#include "CActionDanceBattleManagerExports.h"
#include "CActInputDeviceManagerExports.h"
#include "CInputDeviceListenerExports.h"
#include "MemoryMgr.h"

extern "C"
{
    Y5LIB_EXPORT inline void LIB_UNSAFE_NOP(void* addr, unsigned int length)
    {
        mem::Nop((BYTE*)addr, length);
    };


    Y5LIB_EXPORT inline void LIB_UNSAFE_PATCH(void* addr, BYTE* buf, unsigned int length)
    {
        mem::Patch((BYTE*)addr, buf, length);
    };

    Y5LIB_EXPORT inline void* LIB_PATTERN_SEARCH(const char* pattern)
    {
        return PatternScan(GetModuleHandle(NULL), pattern);
    };

    Y5LIB_EXPORT inline void* LIB_READ_RELATIVE_ADDRESS(void* addr, int instruction_length)
    {
        return  resolve_relative_addr(addr, instruction_length);
    };

    Y5LIB_EXPORT inline void* LIB_READ_CALL(void* addr)
    {
        return (void*)Memory::ReadCall2(addr);
    };
}