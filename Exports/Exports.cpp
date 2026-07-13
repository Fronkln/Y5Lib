#pragma once
#include "LibraryExports.h"
#include "EntityExports.h"
#include "CCameraBaseExports.h"
#include "HumanExports.h"
#include "HumanModelExports.h"
#include "FighterExports.h"
#include "FighterController_Exports.h"
#include "FighterModeExports.h"
#include "FighterCommandManagerExports.h"
#include "Player_Exports.h"
#include "MotionExports.h"
#include "CHActExports.h"
#include "CActionManagerExports.h"
#include "CActionAuthManagerExports.h"
#include "CActionFighterManagerExports.h"
#include "CActionFighterSyncManagerExports.h"
#include "CActionCtrlTypeManagerExports.h"
#include "CActionEnemyDisposeManagerExports.h"
#include "CActionMotionManagerExports.h"
#include "CActionEntityManagerExports.h"
#include "CActionCameraManagerExports.h"
#include "CActionReactorManagerExports.h"
#include "CActionStageManagerExports.h"
#include "CActionSoundManagerExports.h";
#include "CActionCCCManagerExports.h"
#include "CActionHActManagerExports.h"
#include "CActionHActCHPManager_Exports.h"
#include "CSequenceManagerExports.h"
#include "CScenarioManagerExports.h"
#include "CLiveBtlPlayerExports.h"
#include "CActionLiveBattleManagerExports.h"
#include "CActionPrincessLeagueManagerExports.h"
#include "CActionDanceBattleManagerExports.h"
#include "CActInputDeviceManagerExports.h"
#include "CInputDeviceListenerExports.h"
#include "CFontExports.h"
#include "CHumanInfoExports.h"
#include "ScreenExports.h"
#include "criAdx2PlayerExports.h"
#include "MemoryMgr.h"
#include "buffer.h"

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

    Y5LIB_EXPORT inline void LIB_WRITE_CALL(void* addr, void* func)
    {
        Memory::InjectHook(addr, func);
    };

    Y5LIB_EXPORT inline void* LIB_UNSAFE_ALLOC_BUFFER(void* origin)
    {
        return AllocateBuffer(origin);
    };


    typedef void(__fastcall* _tFunc)(bool* in_hit, __m128* start, __m128* end, __int64 mask, BYTE* idk, int a6);
    Y5LIB_EXPORT inline void LIB_TEST(bool* in_hit, __m128* start, __m128* end, __int64 mask)
    {
        _tFunc testo = (_tFunc)0x140F42E60;

        BYTE idfk = 0;
        testo(in_hit, start, end, mask, 0, 0);
    };
}