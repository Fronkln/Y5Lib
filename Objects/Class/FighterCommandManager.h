#pragma once
#include "..\Struct\FighterCommandID.h"

class CFCMove;

class FighterCommandManager
{
	typedef CFCMove* (__fastcall* _GetCommandInfo)(FighterCommandID& command);
	typedef void(__fastcall* _FindCommandsetID)(void* fcManager, int& out_id, const char* commandsetName);

	static _FindCommandsetID ASM_FindCommandsetID;

public:
	static FighterCommandManager** Instance;

	static _GetCommandInfo GetCommandInfo;

	void FindCommandsetID(int& out_id, const char* commandsetName)
	{
		ASM_FindCommandsetID(this, out_id, commandsetName);
	}
};