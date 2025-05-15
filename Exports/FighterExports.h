#pragma once
#include "defines.h"
#include "Objects/Class/Fighter.h"

extern "C"
{
	Y5LIB_EXPORT inline DisposeInfo* OE_LIB_FIGHTER_GETTER_DISPOSE_INFO(Fighter* fighter)
	{
		if (fighter == nullptr)
			return nullptr;
		else
			return &fighter->disposeInfo;
	}

	Y5LIB_EXPORT inline const char* OE_LIB_FIGHTER_GETTER_MODEL_NAME(Fighter* fighter)
	{
		if (fighter == nullptr)
			return nullptr;
		else
			return (const char*) &fighter->disposeInfo.modelName.string;
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTER_GETTER_INPUT_FLAGS(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->inputFlags;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_INPUT_FLAGS(Fighter* fighter, int val)
	{
		if (fighter == nullptr)
			return; 
		
		fighter->inputFlags = val;
	}

	Y5LIB_EXPORT inline FighterModeManager* OE_LIB_FIGHTER_GETTER_FIGHTERMODEMANAGER(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;

		return fighter->fighterModeManager;
	}
}