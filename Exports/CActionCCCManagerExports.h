#pragma once
#include "defines.h"
#include "Objects/Class/CActionCCCManager.h"
#include "CActionManager.h"
#include "OE.h"


extern "C"
{
	Y5LIB_EXPORT inline bool OE_LIB_CACTIONCCCMANAGER_GETTER_IS_ACTIVE()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->cccManager == nullptr)
			return 0;

		return actMan->cccManager->isActive;
	}

	Y5LIB_EXPORT inline bool OE_LIB_CACTIONCCCMANAGER_PLAY_CCC(LinkedListNode_CCCEntityEntry** node, int entityUID, short groupID, CCCMsgGroupHeader* group, int a6)
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->cccManager == nullptr)
			return 0;

		return actMan->cccManager->PlayCCC(node, entityUID, groupID, group, a6);
	}

	Y5LIB_EXPORT inline CMsgPlay* OE_LIB_CACTIONCCCMANAGER_GETTER_ACTIVE_CCC()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return 0;

		if (actMan->cccManager == nullptr)
			return 0;

		return actMan->cccManager->activeCCC;
	}

	Y5LIB_EXPORT inline int OE_LIB_CACTIONCCCMANAGER_GETTER_CURRENT_TALKER_UID()
	{
		CActionManager* actMan = *OE::ActionManager;

		if (actMan == nullptr)
			return -1;

		if (actMan->cccManager == nullptr)
			return -1;

		return actMan->cccManager->talkerUID;
	}

	Y5LIB_EXPORT inline bool OE_LIB_CMSGPLAY_GETTER_IS_RUNNING(CMsgPlay* play)
	{
		if (play == nullptr)
			return false;

		return play->isRunning;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_IS_RUNNING(CMsgPlay* play, bool value)
	{
		if (play == nullptr)
			return;

		play->isRunning = value;
	}

	Y5LIB_EXPORT inline BYTE OE_LIB_CMSGPLAY_GETTER_CURRENT_EVENT(CMsgPlay* play)
	{
		if (play == nullptr)
			return -1;

		return play->currentEventID;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_CURRENT_EVENT(CMsgPlay* play, int event)
	{
		if (play == nullptr)
			return;

		play->currentEventID = event;
	}

	Y5LIB_EXPORT inline BYTE OE_LIB_CMSGPLAY_GETTER_NEXT_EVENT(CMsgPlay* play)
	{
		if (play == nullptr)
			return -1;

		BYTE* playbackDat = (BYTE*)play->somePlaybackData;
		return playbackDat[9];
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_NEXT_EVENT(CMsgPlay* play, BYTE event)
	{
		if (play == nullptr)
			return;

		play->nextEventOverrideFlag = event <= 0 ? 0xFF : 0xFE;

		BYTE* playbackDat = (BYTE*)play->somePlaybackData;
		playbackDat[9] = event;
	}


	Y5LIB_EXPORT inline float OE_LIB_CMSGPLAY_GETTER_CURRENT_TIME(CMsgPlay* play)
	{
		if (play == nullptr)
			return 0;

		return play->currentEventFrameTime;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_CURRENT_TIME(CMsgPlay* play, int16_t time)
	{
		if (play == nullptr)
			return;

		play->currentEventFrameTime = time;
	}

	Y5LIB_EXPORT inline bool OE_LIB_CMSGPLAY_GETTER_IS_TEXT_COMPLETE(CMsgPlay* play)
	{
		if (play == nullptr)
			return false;

		return play->eventSetting->textComplete;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_IS_TEXT_COMPLETE(CMsgPlay* play, bool value)
	{
		if (play == nullptr)
			return;

		play->eventSetting->textComplete = value;
	}

	Y5LIB_EXPORT inline float OE_LIB_CMSGPLAY_GETTER_CURRENT_TEXT_INDEX(CMsgPlay* play)
	{
		if (play == nullptr)
			return 0;

		return play->currentTextLetter;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_CURRENT_TEXT_INDEX(CMsgPlay* play, float value)
	{
		if (play == nullptr)
			return;

		play->currentTextLetter = value;
	}

	Y5LIB_EXPORT inline float OE_LIB_CMSGPLAY_GETTER_TEXT_LENGTH(CMsgPlay* play)
	{
		if (play == nullptr)
			return 0;

		return play->textLetterCount;
	}

	Y5LIB_EXPORT inline int16_t OE_LIB_CMSGPLAY_GETTER_EVENT_DURATION(CMsgPlay* play)
	{
		if (play == nullptr)
			return -1;

		if (play->eventSetting == nullptr)
			return -1;

		return play->eventSetting->duration;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_TO_NEXT_PAGE(CMsgPlay* play)
	{
		if (play == nullptr)
			return;

		play->ToNextPage();
	}

	Y5LIB_EXPORT inline int OE_LIB_CMSGPLAY_GETTER_FLAGS(CMsgPlay* play)
	{
		if (play == nullptr)
			return 0;

		return play->flags;
	}

	Y5LIB_EXPORT inline int OE_LIB_CMSGPLAY_GETTER_FLAGS2(CMsgPlay* play)
	{
		if (play == nullptr)
			return 0;

		return play->someFlags;
	}

	Y5LIB_EXPORT inline void OE_LIB_CMSGPLAY_SETTER_FLAGS2(CMsgPlay* play, int flags)
	{
		if (play == nullptr)
			return;

		play->someFlags = flags;
	}


	Y5LIB_EXPORT inline int OE_LIB_CMSGPLAY_GETTER_STATE(CMsgPlay* play)
	{
		if (play == nullptr)
			return -1;

		return play->GetState();
	}
}