#pragma once
class criAdx2Player
{
public:
	virtual void VFunc0() {};
	virtual void VFunc1() {};
	virtual void Pause() {};
	virtual void Resume() {};
	virtual bool IsPaused() {};
	virtual void SetStartTime(int time) {};
	virtual void StartStream(const char* path) {};
	virtual void Start() {};
	virtual void VFunc8() {};
	virtual void VFunc9() {};
	virtual void StopWithoutReleaseTime() {};
	virtual void VFunc11() {};
	virtual void VFunc12() {};
};