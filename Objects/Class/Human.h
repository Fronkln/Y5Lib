#pragma once
#include "Entity.h"
#include "CHumanDraw.h"

#pragma pack(push, 1)

class MotionThingy;

class Human : public Entity
{
public:
	Motion::EntityMotion* Motion; //0x0140
	char pad_0148[24]; //0x0148
	class CHumanDraw* Model; //0x0160
	char pad_0168[1208]; //0x0168
	void* N00004915; //0x0620
	char pad_0628[12]; //0x0628
	int32_t someFlags; //0x0634
	char pad_0638[120]; //0x0638
	int32_t aiChip; //0x06B0
	char pad_06B4[4132]; //0x06B4
	class NavigationGoal* navigationGoal; //0x16D8
	char pad_16E0[32]; //0x16E0

	virtual void VFunc51() {};
	virtual void VFunc52() {};
	virtual void VFunc53() {};
	virtual void VFunc54() {};
	virtual void VFunc55() {};
	virtual void VFunc56() {};
	virtual void VFunc57() {};
	virtual void VFunc58() {};
	virtual void VFunc59() {};
	virtual void VFunc60() {};
	virtual void VFunc61() {};
	virtual void VFunc62() {};
	virtual void VFunc63() {};
	virtual void VFunc64() {};
	virtual void VFunc65() {};
	virtual void VFunc66() {};
	virtual void VFunc67() {};
	virtual void VFunc68() {};
	virtual void VFunc69() {};
	virtual void VFunc70() {};
	virtual void VFunc71() {};
	virtual bool IsPlayer() { return false; };
	virtual void VFunc73() {};
	virtual void VFunc74() {};
	virtual void VFunc75() {};
	virtual void VFunc76() {};
	virtual void VFunc77() {};
	virtual int GetFighterIndex() { return -1; };
	virtual void VFunc79() {};
	virtual void VFunc80() {};
	virtual void VFunc81() {};
	virtual void VFunc82() {};
	virtual void VFunc83() {};
	virtual void VFunc84() {};
	virtual void VFunc85() {};
	virtual void VFunc86() {};
	virtual void VFunc87() {};
	virtual void VFunc88() {};
	virtual void VFunc89() {};
	virtual void VFunc90() {};
	virtual void VFunc91() {};
	virtual void VFunc92() {};
	virtual void VFunc93() {};
}; //Size: 0x06A4

#pragma pack(pop)