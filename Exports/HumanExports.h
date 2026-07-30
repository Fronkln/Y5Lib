#pragma once
#include "defines.h"
#include "Objects/Class/Human.h"

extern "C"
{
	Y5LIB_EXPORT inline Motion::EntityMotion* OE_LIB_HUMAN_GETTER_MOTION(Human* ent)
	{
		if (ent == nullptr)
			return nullptr;
		else
			return ent->Motion;
	}

	Y5LIB_EXPORT inline CHumanDraw* OE_LIB_HUMAN_GETTER_MODEL(Human* ent)
	{
		if (ent == nullptr)
			return nullptr;
		else
			return ent->Model;
	}

	Y5LIB_EXPORT inline int OE_LIB_HUMAN_GETTER_FIGHTER_INDEX(Human* human)
	{
		if (human == nullptr)
			return -1;
		else
			return human->GetFighterIndex();
	}

	Y5LIB_EXPORT inline bool OE_LIB_HUMAN_IS_PLAYER(Human* human)
	{
		if (human == nullptr)
			return false;
		else
			return human->IsPlayer();
	}

	Y5LIB_EXPORT inline int OE_LIB_HUMAN_GETTER_VOICER(Human* human)
	{
		if (human == nullptr)
			return 0;
		else
			return human->Model->voicerID;
	}

	Y5LIB_EXPORT inline int OE_LIB_HUMAN_GETTER_AI_CHIP(Human* human)
	{
		if (human == nullptr)
			return 0;
		else
			return human->aiChip;
	}
}