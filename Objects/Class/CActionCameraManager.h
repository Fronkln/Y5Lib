#pragma once
#include "Objects/Class/CActionBase.h"

#pragma pack(push, 1)

class CActionCameraManager : public CActionBase
{
public:
	char pad_01C8[168]; //0x01C8
	class CCameraBase* (*camerasPointer)[128]; //0x0270
	int32_t cameraCount; //0x0278
	char pad_027C[4]; //0x027C
	class CCameraBase* cameras[128]; //0x0280
	char pad_0680[5392]; //0x0680
	int32_t cameraCount2; //0x1B90
	int32_t currentCameraID; //0x1B94
	char pad_1B98[48]; //0x1B98
	class CCameraBase* activeCamera; //0x1BC8
	char pad_1BD0[48]; //0x1BD0
}; //Size: 0x1C00

#pragma pack(pop)