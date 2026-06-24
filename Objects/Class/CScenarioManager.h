#pragma once

typedef void(__fastcall* CSCENARIOMANAGER_LoadPlayerPos)(void* thisPtr, int playerPosID, bool unk);
typedef void(__fastcall* CSCENARIOMANAGER_LoadScenario)(void* thisPtr, unsigned int scenarioID);


class CScenarioManager
{
private:
	static CSCENARIOMANAGER_LoadPlayerPos ASM_LoadPlayerPos;
	static CSCENARIOMANAGER_LoadScenario ASM_LoadScenario;
public:
	void LoadPlayerPos(int playerPosID, bool unk)
	{
		ASM_LoadPlayerPos(this, playerPosID, unk);
	}

	void LoadScenario(unsigned int scenarioID)
	{
		ASM_LoadScenario(this, scenarioID);
	}
};

