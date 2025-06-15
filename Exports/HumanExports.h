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

	Y5LIB_EXPORT inline HumanModel* OE_LIB_HUMAN_GETTER_MODEL(Human* ent)
	{
		if (ent == nullptr)
			return nullptr;
		else
			return ent->Model;
	}
}