#pragma once
#include "defines.h"
#include "Objects/Class/CActionCameraManager.h"
#include "CActionManager.h"
#include "OE.h"


extern "C"
{
	Y5LIB_EXPORT inline CCameraBase* OE_LIB_CACTIONCAMERAMANAGER_GETTER_ACTIVE_CAMERA()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->actionCameraManager == nullptr)
			return 0;

		return actMan->actionCameraManager->activeCamera;
	}
}