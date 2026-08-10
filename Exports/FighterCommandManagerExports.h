#pragma once
#include "defines.h"
#include "Objects/Class/FighterCommandManager.h"


extern "C"
{
	Y5LIB_EXPORT inline CFCMove* OE_LIB_FIGHTERCOMMANDMANAGER_GET_COMMAND_INFO(FighterCommandID command)
	{
		return FighterCommandManager::GetCommandInfo(command);
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTERCOMMANDMANAGER_FIND_COMMANDSET_ID(const char* commandsetName)
	{
		FighterCommandManager* fcMan = *FighterCommandManager::Instance;

		int result = 0;
		fcMan->FindCommandsetID(result, commandsetName);

		return result;
	}
}