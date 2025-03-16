// pch.h: This is a precompiled header file.
// Files listed below are compiled only once, improving build performance for future builds.
// This also affects IntelliSense performance, including code completion and many code browsing features.
// However, files listed here are ALL re-compiled if any one of them is updated between builds.
// Do not add files here that you will be updating frequently as this negates the performance advantage.

#ifndef PCH_H
#define PCH_H

// add headers that you want to pre-compile here
#include "framework.h"
#include "Objects/Struct/vec.h"
#include "Objects/Struct/matrix.h"
#include "Objects/Struct/pxd_hash.h"
#include <cstdint>
#include <algorithm>
#include <vector>
#include "PatternScan.h"

namespace mem
{
    template <typename T>
    inline T* FindDMAAddy(uintptr_t ptr, std::vector<unsigned int> offsets)
    {
        uintptr_t addr = ptr;
        for (unsigned int i = 0; i < offsets.size(); ++i)
        {
            addr = *(uintptr_t*)addr;
            addr += offsets[i];
        }
        return (T*)addr;
    }

    inline uintptr_t FindDMAAddy(uintptr_t ptr, std::vector<unsigned int> offsets)
    {
        uintptr_t addr = ptr;
        for (unsigned int i = 0; i < offsets.size(); ++i)
        {
            addr = *(uintptr_t*)addr;
            addr += offsets[i];
        }
        return addr;
    }

    inline void Patch(BYTE* dst, BYTE* src, unsigned int size)
    {
        DWORD oldProtect;

        VirtualProtect(dst, size, PAGE_EXECUTE_READWRITE, &oldProtect);
        memcpy(dst, src, size);
        VirtualProtect(dst, size, oldProtect, &oldProtect);
    }

    inline void Nop(BYTE* dst, unsigned int size)
    {
        DWORD oldProtect;

        VirtualProtect(dst, size, PAGE_EXECUTE_READWRITE, &oldProtect);
        memset(dst, 0x90, size);
        VirtualProtect(dst, size, oldProtect, &oldProtect);
    }
}

#endif //PCH_H
