#pragma once
#include <cstdint>

class MsgChoice
{
public:
	char* choiceText; //0x0000
	char pad_0008[24]; //0x0008
}; //Size: 0x0020

class CMsgChoice
{

public:

	virtual ~CMsgChoice();
	virtual void Func1() {};
	virtual void Update() {};
	virtual void Func3() {};
	virtual void Func4() {};
	virtual void Func5() {};
	virtual void Func6() {};
	virtual void Func7() {};
	virtual void ChoiceSelectionUIUpdate() {};
	virtual void Func9() {};
	virtual void Func10() {};
	virtual void Func11() {};
	virtual void Func12() {};
	virtual void Func13() {};
	virtual void OnChoiceMade() {};
	virtual void Func15() {};

	class MsgChoice choices[32]; //0x0008
	uint32_t choicesCount; //0x0408
	char pad_040C[44]; //0x040C
	int32_t defaultChoice; //0x0438
	char pad_043C[4]; //0x043C
	int32_t currentChoice; //0x0440
	int32_t N000069E7; //0x0444
	uint32_t choicesCountPerPage; //0x0448 if there are more choices than this amount u can scroll down to see other chocies
	float N0000690A; //0x044C
	float choiceTime; //0x0450
	char pad_0454[12]; //0x0454
	class MsgChoice* choicesPtrs[32]; //0x0460
	char pad_0560[288]; //0x0560
	int32_t choiceMade; //0x0680
	char pad_0684[144]; //0x0684
	uint32_t uiCurrentChoice; //0x0714
	char pad_0718[56]; //0x0718
}; //Size: 0x0750