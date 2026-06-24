#pragma once
#include "defines.h"
#include "Objects/Class/FighterCommandManager.h"


extern "C"
{
	Y5LIB_EXPORT inline CFCMove* OE_LIB_FIGHTERCOMMANDMANAGER_GET_COMMAND_INFO(FighterCommandID command)
	{
		return FighterCommandManager::GetCommandInfo(command);
	}
}