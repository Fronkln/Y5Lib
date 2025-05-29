#pragma once
#include "CActionBase.h"
#include "CFileBase.h"

class CFileMotionProperty;
class MotionManager;
class CActionMotionManager;

typedef void* (__fastcall* MOTIONMANAGER_LoadGMTDirect)(MotionManager* motMan, unsigned int gmtID, int unknown, int heapCategory);
typedef unsigned int (__fastcall* FILEMOTIONPROPERTY_GetGMTID)(CFileMotionProperty* fileMotProperty, char* gmtName);

class CFileMotionProperty : public CFileBase
{
	static FILEMOTIONPROPERTY_GetGMTID ASM_GetGMTID;

public:
	unsigned int GetGMTID(char* gmtName)
	{
		return ASM_GetGMTID(this, gmtName);
	}
}; //Size: 0x0148

class MotionManager
{
	static MOTIONMANAGER_LoadGMTDirect ASM_LoadGMTDirect;
public:
	void* vfptr; //0x0000
	char pad_0008[19224]; //0x0008

	void LoadGMTDirect(unsigned int gmtID, int unknown, int heapCategory)
	{
		ASM_LoadGMTDirect(this, gmtID, unknown, heapCategory);
	}
}; //Size: 0x4B20

class CActionMotionManager : public CActionBase
{
public:
	char pad_01C8[8]; //0x01C8
	MotionManager MotionManager; //0x01D0
	CFileMotionProperty* fileProperty; //0x4CF0
	CFileBase* fileActionset; //0x4CF8
	char pad_4D00[24672]; //0x4D00
}; //Size: 0xAD60