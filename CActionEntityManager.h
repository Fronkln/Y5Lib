#pragma once
#include "Objects/Class/Entity.h"

class CActionEntityManager
{
	typedef Entity*(__fastcall* _GetEntityByUID)(void* thisPtr, int uid);

private:
	static _GetEntityByUID ASM_GetEntityByUID;

public:
	Entity* GetEntityByUID(int uid)
	{
		return ASM_GetEntityByUID(this, uid);
	}
};