#pragma once
#include "defines.h"
#include "Objects/Class/CInputDeviceListener.h"


extern "C"
{
	Y5LIB_EXPORT inline void* OE_LIB_CINPUTDEVICELISTENER_GETTER_SLOT(CInputDeviceListener* listener)
	{
		if (listener == nullptr)
			return nullptr;

		return listener->deviceSlot;
	}

	Y5LIB_EXPORT inline void OE_LIB_CINPUTDEVICELISTENER_SETTER_SLOT(CInputDeviceListener* listener, void* slot)
	{
		if (listener == nullptr)
			return;

		listener->deviceSlot = (CInputDeviceSlot*)slot;
	}
}