#pragma once
#include "defines.h"
#include "Objects/Class/CHAct.h"

extern "C"
{
	Y5LIB_EXPORT inline const char* OE_LIB_HACT_GET_NAME(CHAct* hact)
	{
		if (hact == nullptr)
			return 0;

		return (const char*)&hact->name;
	}

	Y5LIB_EXPORT inline float OE_LIB_HACT_GET_CURRENT_FRAME(CHAct* hact)
	{
		if (hact == nullptr)
			return 0;

		return hact->currentTime;
	}

	Y5LIB_EXPORT inline void OE_LIB_HACT_SET_CURRENT_FRAME(CHAct* hact, float frame)
	{
		if (hact == nullptr)
			return;

		hact->currentTime = frame;
		hact->previousTime = frame;
		hact->timeStep = frame / 0.240;
	}

	Y5LIB_EXPORT inline float OE_LIB_HACT_GET_END_FRAME(CHAct* hact)
	{
		if (hact == nullptr)
			return 0;

		return hact->endFrame;
	}

	Y5LIB_EXPORT inline int32_t OE_LIB_HACT_GET_FLAGS(CHAct* hact)
	{
		if (hact == nullptr)
			return 0;

		return hact->flags;
	}

	Y5LIB_EXPORT inline void OE_LIB_HACT_SET_FLAGS(CHAct* hact, int32_t flags)
	{
		if (hact == nullptr)
			return;

		hact->flags = flags;
	}

	Y5LIB_EXPORT inline Matrix4x4 OE_LIB_HACT_GET_TRANSFORM(CHAct* hact)
	{
		if (hact == nullptr)
			return Matrix4x4();

		return hact->transform;
	}

	Y5LIB_EXPORT inline void OE_LIB_HACT_SET_TRANSFORM(CHAct* hact, Matrix4x4 matrix)
	{
		if (hact == nullptr)
			return;

		hact->transform = matrix;
	}
}