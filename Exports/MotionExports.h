#pragma once
#include "defines.h"
#include "Objects/Class/FighterMotion.h"

extern "C"
{
	Y5LIB_EXPORT inline Matrix4x4 OE_LIB_MOTION_GETTER_SCALE(Motion::EntityMotion* mot)
	{
		if (mot == nullptr)
			return Matrix4x4();

		return mot->Scale;
	}

	Y5LIB_EXPORT inline void OE_LIB_MOTION_SET_POSITION(Motion::HumanMotion* mot, vec4f pos)
	{
		if (mot == nullptr)
			return;

		mot->Position = pos;

		if(mot->collisionShape != nullptr)
			mot->collisionShape->Position = pos;
		
		mot->SetPosition(&pos);
		//((Motion::HumanMotion*)mot)->collisionShape->
	}

	Y5LIB_EXPORT inline short OE_LIB_HUMANMOTION_GET_ANGLE_Y(Motion::HumanMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->rotY;
	}

	Y5LIB_EXPORT inline void OE_LIB_HUMANMOTION_SET_ANGLE_Y(Motion::HumanMotion* mot, short angle)
	{
		if (mot == nullptr)
			return;

		mot->rotY = angle;
	}

	Y5LIB_EXPORT inline Matrix4x4 OE_LIB_BONEMOTION_GETTER_MATRIX(Motion::BoneMotion* mot)
	{
		if (mot == nullptr)
			return Matrix4x4();

		return mot->Matrix;
	}

	Y5LIB_EXPORT inline unsigned int OE_LIB_BONEMOTION_GETTER_CURRENT_ANIMATION(Motion::BoneMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->CurrentAnim;
	}

	Y5LIB_EXPORT inline float OE_LIB_BONEMOTION_GETTER_ANIMATION_TIME(Motion::BoneMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->CurrentFrame;
	}

	Y5LIB_EXPORT inline void OE_LIB_BONEMOTION_SETTER_ANIMATION_TIME(Motion::BoneMotion* mot, float time)
	{
		if (mot == nullptr)
			return;

		mot->CurrentFrame = time;
	}

	Y5LIB_EXPORT inline float OE_LIB_BONEMOTION_GETTER_PREVIOUS_ANIMATION_TIME(Motion::BoneMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->PreviousFrame;
	}

	Y5LIB_EXPORT inline void OE_LIB_BONEMOTION_SETTER_PREVIOUS_ANIMATION_TIME(Motion::BoneMotion* mot, float time)
	{
		if (mot == nullptr)
			return;

		mot->PreviousFrame = time;
	}

	Y5LIB_EXPORT inline unsigned int OE_LIB_BONEMOTION_GETTER_NEXT_ANIMATION(Motion::BoneMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->nextAnim;
	}

	Y5LIB_EXPORT inline void OE_LIB_BONEMOTION_SETTER_NEXT_ANIMATION(Motion::BoneMotion* mot, unsigned int anim)
	{
		if (mot == nullptr)
			return;

		mot->nextAnim = anim;
	}

	Y5LIB_EXPORT inline unsigned int OE_LIB_HUMANMOTION_GETTER_FLAGS(Motion::HumanMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->flags;
	}

	Y5LIB_EXPORT inline void OE_LIB_HUMANMOTION_SETTER_FLAGS(Motion::HumanMotion* mot, unsigned int flags)
	{
		if (mot == nullptr)
			return;

		mot->flags = flags;
	}

	Y5LIB_EXPORT inline unsigned int OE_LIB_HUMANMOTION_GETTER_MODE(Motion::HumanMotion* mot)
	{
		if (mot == nullptr)
			return 0;

		return mot->motionMode;
	}

	Y5LIB_EXPORT inline void OE_LIB_HUMANMOTION_SETTER_MODE(Motion::HumanMotion* mot, unsigned int mode)
	{
		if (mot == nullptr)
			return;

		mot->motionMode = mode;
	}
}