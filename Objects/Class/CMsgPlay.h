#pragma once
#include <cstdint>

class MsgPlayEventSettings // data from Dialogue Settings node mostly
{
public:
	char pad_0000[2]; //0x0000
	bool textComplete; //0x0002
	char pad_0003[3]; //0x0003
	uint16_t textLength; //0x0006
	int16_t duration; //0x0008
	int32_t entityUID; //0x000C
	char pad_0010[16]; //0x0010
}; //Size: 0x0020

class CMsgPlay
{

public:
	char pad_0008[24]; //0x0008
	void* somePlaybackData; //0x0020
	char pad_0028[4]; //0x0028
	int32_t isRunning; //0x002C set to 0 and the whole thing is paused
	char pad_0030[12]; //0x0030
	int32_t flags; //0x003C
	int32_t totalEventTickTime; //0x0040
	char pad_0044[28]; //0x0044
	int32_t currentEventID; //0x0060
	char pad_0064[1056]; //0x0064
	float currentTextLetter; //0x0484
	float textLetterCount; //0x0488
	char pad_048C[12]; //0x048C
	float currentEventFrameTime; //0x0498
	char pad_049C[4]; //0x049C
	class MsgPlayEventSettings* eventSetting; //0x04A0
	int32_t someFlags; //0x04A8
	uint8_t nextEventOverrideFlag; //0x04AC not always set, probably only during branch node etc
	char pad_04AD[35]; //0x04AD
	uint8_t N00004547; //0x04D0
	char pad_04D1[111]; //0x04D1
	int32_t isVoicedPage; //0x0540
	char currentVoicePath[260]; //0x0544
	char pad_0648[4]; //0x0648
	float currentEventTotalFrameTime; //0x064C
	char pad_0650[8488]; //0x0650
	int32_t N000066FD; //0x2778
	char pad_277C[628]; //0x277C

	virtual void Func0() {};
	virtual void Func1() {};
	virtual void Func2() {};
	virtual void Func3() {};
	virtual void Func4() {};
	virtual void Func5() {};
	virtual void Func6() {};
	virtual void Func7() {};
	virtual void Func8() {};
	virtual void Func9() {};
	virtual void Func10() {};
	virtual void Func11() {};
	virtual void Func12() {};
	virtual void Func13() {};
	virtual void Func14() {};
	virtual void Func15() {};
	virtual void Func16() {};
	virtual void Func17() {};
	virtual void Func18() {};
	virtual void Func19() {};
	virtual void Func20() {};
	virtual void Func21() {};
	virtual void Func22() {};
	virtual void ToNextPage() {};
	virtual int GetState() { return 0; }
	virtual bool IsInputGoNext(int* unknown) { return 0; }
}; //Size: 0x09F0