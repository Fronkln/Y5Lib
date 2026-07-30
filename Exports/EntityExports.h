#pragma once
#include "defines.h"
#include "Objects/Class/Entity.h"


extern "C"
{
	Y5LIB_EXPORT inline void OE_LIB_ENTITY_GET_POSITION(Entity* entity, __m128* in_vec)
	{
		if (entity == nullptr)
		{
			*in_vec = _mm_setzero_ps();
			return;
		}

		entity->GetPosition(in_vec);
	}

	Y5LIB_EXPORT inline void OE_LIB_ENTITY_GET_CROWN_POSITION(Entity* entity, __m128* in_vec)
	{
		if (entity == nullptr)
		{
			*in_vec = _mm_setzero_ps();
			return;
		}

		entity->GetCrownPosition(in_vec);
	}


	Y5LIB_EXPORT inline void OE_LIB_ENTITY_SET_POSITION(Entity* entity, vec4f value)
	{
		if (entity == nullptr)
			return;

		entity->SetPosition(value);
	}

	Y5LIB_EXPORT inline void OE_LIB_ENTITY_SET_VISIBILITY(Entity* entity, bool visible)
	{
		if (entity == nullptr)
			return;

		entity->SetVisibility(visible);
	}

	Y5LIB_EXPORT inline bool OE_LIB_ENTITY_IS_VISIBLE(Entity* entity)
	{
		if (entity == nullptr)
			return false;

		return entity->IsVisible();
	}

	Y5LIB_EXPORT inline void OE_LIB_ENTITY_WARP_TO_POSITION(Entity* entity, vec4f value)
	{
		if (entity == nullptr)
			return;

		entity->WarpToPosition(value);
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

	Y5LIB_EXPORT inline void* OE_LIB_ENTITY_GETTER_MSG_DATA(Entity* entity)
	{
		if (entity == nullptr)
			return 0;

		return entity->cccEntry;
	}

	Y5LIB_EXPORT inline bool OE_LIB_ENTITY_CAN_SHOW_TEXT_BUBBLE(Entity* entity)
	{
		if (entity == nullptr)
			return false();

		return entity->CanShowTextBubble();
	}
}