#pragma once
#include "..\Struct\FighterCommandID.h"

class CFCMove;

class FighterCommandManager
{
	typedef CFCMove* (__fastcall* _GetCommandInfo)(FighterCommandID& command);

public:
	static _GetCommandInfo GetCommandInfo;
};