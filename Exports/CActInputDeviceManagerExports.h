#pragma once
#include "defines.h"
#include "Objects/Class/CActInputDeviceManager.h"

class CInputDeviceSlot;

extern "C"
{
	Y5LIB_EXPORT inline CInputDeviceSlot* OE_LIB_CACTIONPUTDEVICEMANAGER_GET_SLOT(int slot)
	{
		CActInputDeviceManager* man = *CActInputDeviceManager::instance;

		if (man == nullptr)
			return 0;

		return man->slots[slot];
	}

	Y5LIB_EXPORT inline void* OE_LIB_INPUT_GET_RAW_DATA(int slot)
	{
		if (CActInputDeviceManager::inputDatas == nullptr)
			return 0;

		long long val = (long long)CActInputDeviceManager::inputDatas;
		long long addr = val + 0x1F0;


		long long datas = *(long*)(addr);

		void* res = (void*)(datas + (slot * 480));
		return res;
	}
}