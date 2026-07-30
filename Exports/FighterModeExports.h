#pragma once
#include "defines.h"
#include "Objects/Class/FighterMode.h"

extern "C"
{
	Y5LIB_EXPORT inline FighterMode* OE_LIB_FIGHTERMODEMANAGER_GETTER_CURRENT_MODE(FighterModeManager* fighterModeMan)
	{
		if (fighterModeMan == nullptr)
			return nullptr;
		else
			return fighterModeMan->currentMode;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTERMODEMANAGER_TODEADBYDAMAGE(FighterModeManager* fighterModeMan, DamageInfo* damage)
	{
		if (fighterModeMan == nullptr || damage == nullptr)
			return;
		else
			fighterModeMan->ToDeadByDamage(damage);
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTERMODEMANAGER_TOATTACK(FighterModeManager* fighterModeMan, FighterCommandID id)
	{
		if (fighterModeMan == nullptr)
			return;
		else
			fighterModeMan->ToAttack(id);
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTERMODEMANAGER_TOPROVOKE(FighterModeManager* fighterModeMan, FighterCommandID id)
	{
		if (fighterModeMan == nullptr)
			return;
		else
			fighterModeMan->ToProvoke(id);
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTERMODEMANAGER_TOACTION(FighterModeManager* fighterModeMan, FighterCommandID id)
	{
		if (fighterModeMan == nullptr)
			return;
		else
			fighterModeMan->ToAction(id);
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTERMODEMANAGER_SET_COMMANDSET(FighterModeManager* fighterModeMan, const char* commandset)
	{
		if (fighterModeMan == nullptr)
			return;
		else
			fighterModeMan->SetCommandset(0, commandset);
	}

	Y5LIB_EXPORT inline FighterCommandID OE_LIB_FIGHTERMODEMANAGER_GET_CURRENT_COMMAND(FighterModeManager* fighterModeMan)
	{
		if (fighterModeMan == nullptr)
			return FighterCommandID();
		else
		{
			FighterCommandID result;
			fighterModeMan->GetCurrentCommand(result);

			return result;
		}
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTERMODEMANAGER_GET_COMMANDSET(FighterModeManager* fighterModeMan, int idx)
	{
		if (fighterModeMan == nullptr)
			return -1;

		if (idx < 0 || idx > 2)
			return -1;

		return fighterModeMan->commandSets[idx];
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTERMODEMANAGER_GET_CURRENT_COMMANDSET(FighterModeManager* fighterModeMan)
	{
		if (fighterModeMan == nullptr)
			return -1;

		return fighterModeMan->commandSets[fighterModeMan->activeCommandset];
	}

	Y5LIB_EXPORT inline Fighter* OE_LIB_FIGHTERMODEMANAGER_GETTER_OWNER(FighterModeManager* fighterModeMan)
	{
		if (fighterModeMan == nullptr)
			return 0;
		else
			return fighterModeMan->fighter;
	}

	Y5LIB_EXPORT inline char* OE_LIB_FIGHTERMODE_GETTER_NAME(FighterMode* fighterMode)
	{
		if (fighterMode == nullptr)
			return nullptr;
		else
			return fighterMode->modeName;
	}

	Y5LIB_EXPORT inline Fighter* OE_LIB_FIGHTERMODE_GETTER_FIGHTER(FighterMode* fighterMode)
	{
		if (fighterMode == nullptr)
			return nullptr;
		else
			return fighterMode->fighter;
	}
}