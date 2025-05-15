#pragma once
#include <cstdint>

typedef int(__fastcall* HACTMANAGER_PreloadHAct)(const char* name, const char* path, int flags);
typedef void(__fastcall* HACTMANAGER_PlayHAct)(int idx, int flags);
typedef void(__fastcall* HACTMANAGER_RegisterFighterOnHAct)(int hactIdx, const char* replaceName, int fighterIndex, int unknown);

class CActionHActManager
{
public:
	char pad_0000[456]; //0x0000
	int64_t currentHActIdx; //0x01C8
	class CHActEntry* currentPreloadedHAct; //0x01D0
	class CHActEntry* currentHAct; //0x01D8
	class CHActEntry* hactToPlay; //0x01E0

	static HACTMANAGER_PreloadHAct ASM_PreloadHAct;
	static HACTMANAGER_PlayHAct ASM_PlayHAct;
	static HACTMANAGER_RegisterFighterOnHAct ASM_RegisterFighterOnHAct;
};