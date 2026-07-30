#pragma once
#include "pch.h"

#pragma pack(push, 1)

class CActionBase
{
public:
	char pad_0008[448]; //0x0008

	virtual ~CActionBase(){}
	virtual void Func0() {};
	virtual void SetupThreadMode() {};
	virtual void Func3() {};
	virtual void Update() {};
	virtual void Func5() {};
	virtual void Func6() {};
	virtual void Func7() {};
	virtual void Draw() {};
	virtual void Func9() {};
	virtual void Func10() {};
	virtual void Func11() {};
	virtual void Func12() {};
}; //Size: 0x01C8


#pragma pack(pop)