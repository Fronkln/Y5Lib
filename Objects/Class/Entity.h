#pragma once
#include "pch.h"
#include "EntityBase.h"
#include "EntityMotion.h"

#pragma pack(push, 1)

class Entity : public EntityBase
{
public:
	char pad_0028[40]; //0x0028
	uint32_t UID; //0x0050
	char pad_0054[20]; //0x0054
	class CCCEntityEntry* cccEntry; //0x0068
	vec4f Position; //0x0070
	char pad_0080[4]; //0x0080
	int32_t RotationY; //0x0084
	char pad_0088[8]; //0x0088
	class CInputDeviceListener* InputController; //0x0090
	void* N00003BE3; //0x0098
	char pad_00A0[144]; //0x00A0
	char* ClassName; //0x0130
	char pad_0138[8]; //0x0138

	virtual void VFunc0() {};
	virtual void VFunc1() {};
	virtual void VFunc2() {};
	virtual void GetPositionCore(vec4f& in_pos) {};
	virtual vec4f& GetPosition(vec4f& in_pos) {};
	virtual void SetPosition(vec4f& position) {};
	virtual void WarpToPosition(vec4f& position) {};
	virtual void VFunc7() {};
	virtual void VFunc8() {};
	virtual void VFunc9() {};
	virtual void VFunc10() {};
	virtual void VFunc11() {};
	virtual void VFunc12() {};
	virtual void VFunc13() {};
	virtual void VFunc14() {};
	virtual void VFunc15() {};
	virtual void VFunc16() {};
	virtual void VFunc17() {};
	virtual void VFunc18() {};
	virtual void VFunc19() {};
	virtual void VFunc20() {};
	virtual void VFunc21() {};
	virtual void VFunc22() {};
	virtual void VFunc23() {};
	virtual void VFunc24() {};
	virtual void VFunc25() {};
	virtual void VFunc26() {};
	virtual void VFunc27() {};
	virtual void VFunc28() {};
	virtual void VFunc29() {};
	virtual void VFunc30() {};
	virtual void VFunc31() {};
	virtual vec4f& GetCrownPosition(vec4f& in_pos) {};
	virtual void VFunc33() {};
	virtual void VFunc34() {};
	virtual void VFunc35() {};
	virtual void VFunc36() {};
	virtual void VFunc37() {};
	virtual bool CanShowTextBubble() {};
	virtual void VFunc39() {};
	virtual void VFunc40() {};
	virtual void VFunc41() {};
	virtual void VFunc42() {};
	virtual void VFunc43() {};
	virtual void VFunc44() {};
	virtual void VFunc45() {};
	virtual void VFunc46() {};
	virtual void VFunc47() {};
	virtual void VFunc48() {};
	virtual void VFunc49() {};
	virtual void VFunc50() {};
}; //Size: 0x008C

#pragma pack(pop)