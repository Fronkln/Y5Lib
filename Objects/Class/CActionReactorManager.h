#pragma once
#include "pch.h"
#include "Objects/Class/Entity.h"

class CActionReactorManager;

typedef Entity*(__fastcall* REACTORMANAGER_CreateReactor)(CActionReactorManager* rMan, const char* asset, vec4f* spawnPosition, vec4f* rotation, vec4f* unk1, vec4f* unk2, long long unk3, int unk4, int unk5);

class CActionReactorManager
{
public:
	static REACTORMANAGER_CreateReactor ASM_CreateReactor;

	Entity* CreateReactor(const char* asset, vec4f* spawnPosition, vec4f* rotation, vec4f* unk1, vec4f* unk2, long long unk3, int unk4, int unk5) {
		
		return ASM_CreateReactor(this, asset, spawnPosition, rotation, unk1, unk2, unk3, unk4, unk5);
	}
};