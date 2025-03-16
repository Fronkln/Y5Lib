#include "CActInputDeviceManager.h"
#include "PatternScan.h"

CActInputDeviceManager** CActInputDeviceManager::instance = (CActInputDeviceManager**)resolve_relative_addr(PatternScan("48 8B 0D ? ? ? ? E8 ? ? ? ? 48 8B CF E8 ? ? ? ? BA ? ? ? ? 41 B8 ? ? ? ?"));
long* CActInputDeviceManager::inputDatas = (long*)resolve_relative_addr(PatternScan("48 8D 05 ? ? ? ? 48 89 05 ? ? ? ? 33 C0 C3 B8 ? ? ? ?"));