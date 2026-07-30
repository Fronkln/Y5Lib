#pragma once
#include "CActionBase.h"
#include "CMsgChoice.h"
#include "CMsgPlay.h"

class CCCCharacter
{
public:
	int32_t UID; //0x0000
	char pad_0004[140]; //0x0004
}; //Size: 0x0090

class CCCInteractableEntity
{
public:
	int32_t interactionType; //0x0000
	uint32_t entityUID; //0x0004
}; //Size: 0x0008


class CActionCCCManager : public CActionBase
{
	typedef bool(__fastcall* _PlayCCC)(void* thisPtr, class LinkedListNode_CCCEntityEntry** node,
		int entityUID,
		__int16 groupID,
		class CCCMsgGroupHeader* group,
		int32_t a6);

	typedef void* (__fastcall* _GetEntityData)(void* entityHeader);
	typedef CCCCharacter* (__fastcall* _GetCCCCharacterByUID)(CActionCCCManager* manager, int UID);
	typedef void* (__fastcall* _ShowPopup)(CActionCCCManager* manager, void* params, int index);


	static _PlayCCC ASM_PlayCCC;
	static _GetEntityData ASM_GetEntityData;

	class TextBubbleInstance
	{
	public:
		int32_t entityUID; //0x0000
		char pad_0004[4]; //0x0004
		char* textPtr; //0x0008
		float maxDistance; //0x0010
		float currentDistance; //0x0014
		char pad_0018[8]; //0x0018
	}; //Size: 0x0020


public:
	char pad_01C8[64]; //0x01C8
	void* disposeBuffer; //0x0208
	char pad_0210[8]; //0x0210
	class CCCEntityBucketTable* entityBucketTable; //0x0218
	char pad_0220[16]; //0x0220
	int32_t N00003F41; //0x0230
	char pad_0234[8]; //0x0234
	int32_t N0000CE97; //0x023C
	bool isActive; //0x0240
	char pad_0241[7]; //0x0241
	int32_t forcedInteractionEntityUID; //0x0248 can only interact with this entity
	int32_t isDynamicDialogueActive; //0x024C was only set to true when playing dialogue on yamakasa long battle, not ui fade or ccc interact
	char pad_0250[20]; //0x0250
	int32_t playerStateFlags; //0x0264 1 = walking, 2 = running, 4 = unknown
	float stateTimers[3]; //0x0268 time spent on each state bit
	class CCCInteractableEntity targetInteractionInfo; //0x0274
	int32_t targetInteractableEntity; //0x027C
	char pad_0280[8]; //0x0280
	int32_t N00003F4C; //0x0288
	char pad_028C[12]; //0x028C
	int32_t cccType; //0x0298
	char pad_029C[4]; //0x029C
	class CMsgPlay* activeCCC; //0x02A0
	char pad_02A8[20]; //0x02A8
	int32_t cccType2; //0x02BC
	char pad_02C0[16]; //0x02C0
	int32_t talkerUID; //0x02D0
	char pad_02D4[4]; //0x02D4
	void* N00003F56; //0x02D8
	int32_t playerUID; //0x02E0
	char pad_02E4[740]; //0x02E4
	int32_t characterCount; //0x05C8
	char pad_05CC[4]; //0x05CC
	class CCCCharacter characters[32]; //0x05D0
	char pad_17D0[2304]; //0x17D0
	class CMsgChoice* msgChoice; //0x20D0
	char pad_20D8[508]; //0x20D8
	float timeSpentIdling; //0x22D4 Idle CCC plays at around 410-420
	TextBubbleInstance textBubbles[8]; //0x22D8
	int32_t activeBubbles; //0x23D8
	int32_t N000067B0; //0x23DC
	char pad_23E0[5024]; //0x23E0

	bool PlayCCC(LinkedListNode_CCCEntityEntry** node, int entityUID, short groupID, CCCMsgGroupHeader* group, int a6)
	{
		return ASM_PlayCCC(this, node, entityUID, groupID, group, a6);
	}

	static void* GetEntityData(void* entityHeader)
	{
		return ASM_GetEntityData(entityHeader);
	}

	CCCCharacter* GetCCCCharacterByUID(int UID)
	{
		for (int i = 0; i < characterCount; i++)
		{
			if (characters[i].UID == UID)
				return &characters[i];
		}
		
		return nullptr;
	}

	void* ShowPopup(void* params, int index)
	{
		static _ShowPopup ASM_ShowPopup = (_ShowPopup)PatternScan("");
		if (!ASM_ShowPopup)
		{
			// Replace this with the actual address of the ShowPopup function in memory
			uintptr_t address = 0x12345678; // Example address, replace with the correct one
			ASM_ShowPopup = (_ShowPopup)address;
		}
		return ASM_ShowPopup(this, params, index);
	}

}; //Size: 0x3678