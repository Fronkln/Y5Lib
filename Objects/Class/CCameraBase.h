#pragma once
#include "Entity.h"

class CCameraBase : public Entity
{
public:
	int32_t cameraIdx; //0x0140
	void* N0000224E; //0x0144
	char pad_014C[4]; //0x014C
	vec4f currentPosition; //0x0150
	vec4f focusPos; //0x0160
	char pad_0170[16]; //0x0170
	Matrix4x4 N000021E9; //0x0180
	char pad_01C0[64]; //0x01C0
	float nearClip; //0x0200
	float farClip; //0x0204
	float fov; //0x0208
	char pad_020C[36]; //0x020C
	Matrix4x4 N00007B83; //0x0230
	char pad_0270[64]; //0x0270
	float N00007B88; //0x02B0
	int32_t inputFlags; //0x02B4
	char pad_02B8[8]; //0x02B8
}; //Size: 0x02C0