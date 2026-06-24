#pragma once

typedef int(__fastcall* PLAYER_GET_CURRENT_ID)();

class Player
{
	static PLAYER_GET_CURRENT_ID ASM_GetCurrentID;

public:
	static int GetCurrentID() 
	{
		return ASM_GetCurrentID();
	}
};