#pragma once
#include "defines.h"
#include "Objects/Class/Fighter.h"
#include "Objects/Class/Enemy.h"

extern "C"
{
	Y5LIB_EXPORT inline unsigned short OE_LIB_FIGHTER_GETTER_HEALTH(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->CombatInfoPtr->health;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_HEALTH(Fighter* fighter, unsigned short health)
	{
		if (fighter == nullptr)
			return;

		fighter->CombatInfoPtr->health = health;
	}

	Y5LIB_EXPORT inline unsigned short OE_LIB_FIGHTER_GETTER_HEAT(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->CombatInfoPtr->heat;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_HEAT(Fighter* fighter, unsigned short heat)
	{
		if (fighter == nullptr)
			return;

		fighter->CombatInfoPtr->heat = heat;
	}

	Y5LIB_EXPORT inline unsigned short OE_LIB_FIGHTER_GETTER_MAXHEALTH(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->CombatInfoPtr->maxHealth;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_MAXHEALTH(Fighter* fighter, unsigned short health)
	{
		if (fighter == nullptr)
			return;

		fighter->CombatInfoPtr->maxHealth = health;
	}

	Y5LIB_EXPORT inline unsigned short OE_LIB_FIGHTER_GETTER_MAXHEAT(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->CombatInfoPtr->maxHeat;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_MAXHEAT(Fighter* fighter, unsigned short heat)
	{
		if (fighter == nullptr)
			return;

		fighter->CombatInfoPtr->maxHeat = heat;
	}

	Y5LIB_EXPORT inline DisposeInfo* OE_LIB_FIGHTER_GETTER_DISPOSE_INFO(Fighter* fighter)
	{
		if (fighter == nullptr)
			return nullptr;
		else
			return &fighter->disposeInfo;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_DISPOSE_INFO(Fighter* fighter, DisposeInfo* info)
	{
		if (fighter == nullptr)
			return;

		memcpy_s(&fighter->disposeInfo, sizeof(DisposeInfo), info, sizeof(DisposeInfo));
	}

	Y5LIB_EXPORT inline const char* OE_LIB_FIGHTER_GETTER_MODEL_NAME(Fighter* fighter)
	{
		if (fighter == nullptr)
			return nullptr;
		else
			return (const char*)&fighter->disposeInfo.modelName.string;
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTER_GETTER_INPUT_FLAGS(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->InputInfo.buttonMask;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_INPUT_FLAGS(Fighter* fighter, int val)
	{
		if (fighter == nullptr)
			return;

		fighter->InputInfo.buttonMask = val;
	}

	Y5LIB_EXPORT inline float OE_LIB_FIGHTER_GETTER_INPUT_FORWARD_DIRECTION(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->InputInfo.forwardRelated;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_INPUT_FORWARD_DIRECTION(Fighter* fighter, float val)
	{
		if (fighter == nullptr)
			return;

		fighter->InputInfo.forwardRelated = val;
	}

	Y5LIB_EXPORT inline short OE_LIB_FIGHTER_GETTER_INPUT_SIDE_DIRECTION(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->InputInfo.sideRelated1;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_INPUT_SIDE_DIRECTION(Fighter* fighter, short val)
	{
		if (fighter == nullptr)
			return;

		fighter->InputInfo.sideRelated1 = val;
	}

	Y5LIB_EXPORT inline short OE_LIB_FIGHTER_GETTER_INPUT_SIDE_DIRECTION2(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->InputInfo.sideRelated2;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_INPUT_SIDE_DIRECTION2(Fighter* fighter, short val)
	{
		if (fighter == nullptr)
			return;

		fighter->InputInfo.sideRelated2 = val;
	}

	Y5LIB_EXPORT inline FighterModeManager* OE_LIB_FIGHTER_GETTER_FIGHTERMODEMANAGER(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;

		return fighter->fighterModeManager;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_DAMAGE(Fighter* fighter, BYTE val)
	{
		if (fighter == nullptr)
			return;

		fighter->disposeInfo.damage = val;
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTER_GETTER_INDEX(Fighter* fighter)
	{
		if (fighter == nullptr)
			return -1;
		else
			return fighter->fighterIndex;
	}

	Y5LIB_EXPORT inline BYTE OE_LIB_FIGHTER_GETTER_TYPE(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;

		return fighter->disposeInfo.fighterType;
	}


	Y5LIB_EXPORT inline unsigned int OE_LIB_FIGHTER_GETTER_FLAGS(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;

		return fighter->fighterFlags;
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTER_GETTER_SYNC_SERIAL(Fighter* fighter)
	{
		if (fighter == nullptr)
			return 0;
		else
			return fighter->syncSerial;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SET_THINK_MODE(Fighter* fighter, int mode)
	{
		if (fighter == nullptr)
			return;
		else
			fighter->thinkMode = mode;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_TODEAD(Fighter* fighter)
	{
		if (fighter == nullptr)
			return;
		else
			fighter->ToDead();
	}

	Y5LIB_EXPORT inline bool OE_LIB_ENEMY_GETTER_ISUNKILLABLE(Enemy* fighter)
	{
		if (fighter == nullptr)
			return false;
		else
			return fighter->isUnkillable;
	}

	Y5LIB_EXPORT inline void OE_LIB_ENEMY_SETTER_ISUNKILLABLE(Enemy* fighter, bool unKillable)
	{
		if (fighter == nullptr)
			return;

		fighter->isUnkillable = unKillable;
	}

	Y5LIB_EXPORT inline int OE_LIB_FIGHTER_GETTER_FUID(Fighter* fighter)
	{
		if (fighter == nullptr)
			return -1;
		else
			return fighter->disposeInfo.fighterUID;
	}

	Y5LIB_EXPORT inline void OE_LIB_FIGHTER_SETTER_FUID(Fighter* fighter, int val)
	{
		if (fighter == nullptr)
			return;

		fighter->disposeInfo.fighterUID = val;
	}

}