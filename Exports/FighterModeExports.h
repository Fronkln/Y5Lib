#pragma once
#include "defines.h"
#include "Objects/Class/FighterMode.h"

extern "C"
{
	Y5LIB_EXPORT inline FighterMode* OE_LIB_FIGHTERMODEMANAGER_GETTER_CURRENT_MODE(FighterModeManager* fighterModeMan)
	{
		if (fighterModeMan == nullptr)
			return nullptr;
		else
			return fighterModeMan->currentMode;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTERMODEMANAGER_SET_COMMANDSET(FighterModeManager* fighterModeMan, const char* commandset)
	{
		if (fighterModeMan == nullptr)
			return;
		else
			fighterModeMan->SetCommandset(0, commandset);
	}

	Y5LIB_EXPORT inline char* OE_LIB_FIGHTERMODE_GETTER_NAME(FighterMode* fighterMode)
	{
		if (fighterMode == nullptr)
			return nullptr;
		else
			return fighterMode->modeName;
	}
}