#pragma once
#include "CInputDeviceListener.h"

class CSIXAXISListener : public CInputDeviceListener
{
public:
	char pad_0018[8]; //0x0018
};