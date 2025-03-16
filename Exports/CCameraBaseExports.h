#pragma once
#include "defines.h"
#include "Objects/Class/CCameraBase.h"

extern "C"
{
	Y5LIB_EXPORT inline vec4f OE_LIB_CCAMERABASE_GETTER_CURRENT_POSITION(CCameraBase* camera)
	{
		if (camera == nullptr)
			return vec4f();

		return camera->currentPosition;
	}

	Y5LIB_EXPORT inline void OE_LIB_CCAMERABASE_SETTER_CURRENT_POSITION(CCameraBase* camera, vec4f position)
	{
		if (camera == nullptr)
			return;

		camera->currentPosition = position;
	}

	Y5LIB_EXPORT inline vec4f OE_LIB_CCAMERABASE_GETTER_FOCUS_POSITION(CCameraBase* camera)
	{
		if (camera == nullptr)
			return vec4f();

		return camera->focusPos;
	}

	Y5LIB_EXPORT inline void OE_LIB_CCAMERABASE_SETTER_FOCUS_POSITION(CCameraBase* camera, vec4f position)
	{
		if (camera == nullptr)
			return;

		camera->focusPos = position;
	}

	Y5LIB_EXPORT inline Matrix4x4 OE_LIB_CCAMERABASE_GETTER_MATRIX(CCameraBase* camera)
	{
		if (camera == nullptr)
			return Matrix4x4();

		return camera->N000021E9;
	}

	Y5LIB_EXPORT inline float OE_LIB_CCAMERABASE_GETTER_FOV(CCameraBase* camera)
	{
		if (camera == nullptr)
			return 0;

		return camera->fov;
	}

	Y5LIB_EXPORT inline void OE_LIB_CCAMERABASE_SETTER_FOV(CCameraBase* camera, float fov)
	{
		if (camera == nullptr)
			return;

		camera->fov = fov;
	}
}