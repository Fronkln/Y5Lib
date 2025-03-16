#pragma once
#include "defines.h"
#include "Objects/Class/Entity.h"


extern "C"
{
	Y5LIB_EXPORT inline vec4f OE_LIB_ENTITY_GET_POSITION(Entity* entity)
	{
		if (entity == nullptr)
			return vec4f();

		return entity->Position;
	}

	Y5LIB_EXPORT inline void OE_LIB_ENTITY_SET_POSITION(Entity* entity, vec4f value)
	{
		if (entity == nullptr)
			return;

		entity->Position = value;
	}

	Y5LIB_EXPORT inline unsigned short OE_LIB_ENTITY_GETTER_ROTATION_Y(Entity* entity)
	{
		if (entity == nullptr)
			return 0;

		return entity->RotationY;
	}

	Y5LIB_EXPORT inline int OE_LIB_ENTITY_GETTER_UID(Entity* entity)
	{
		if (entity == nullptr)
			return 0;

		return entity->UID;
	}

	Y5LIB_EXPORT inline void* OE_LIB_ENTITY_GETTER_INPUT_CONTROLLER(Entity* entity)
	{
		if (entity == nullptr)
			return 0;

		return entity->InputController;
	}
}