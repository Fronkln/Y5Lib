#pragma once
#include "CActionBase.h"
#include "CFileBase.h"

class CFileMotionProperty;
class MotionResourceManager;
class CActionMotionManager;

typedef void (__fastcall* MOTIONMANAGER_LoadImportantResources)(CActionMotionManager* motMan, bool isBattle);
typedef void* (__fastcall* MOTIONMANAGER_LoadGMTDirect)(MotionResourceManager* motMan, unsigned int gmtID, int unknown, int heapCategory);
typedef void (__fastcall* MOTIONRESOURCEMANAGER_LoadMotionPar)(MotionResourceManager* motMan, char* path, int a1, int a2, int a3, int a4, int a5);
typedef void(__fastcall* MOTIONRESOURCEMANAGER_LoadMotionParToID)(MotionResourceManager* motMan, char* path, int a1, int a2, int a3);
typedef void (__fastcall* MOTIONRESOURCEMANAGER_LoadMotionParWithID)(MotionResourceManager* motMan, int id, int a2);
typedef bool(__fastcall* MOTIONRESOURCEMANAGER_IsMotionParIDLoaded)(MotionResourceManager* motMan, int id);

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

class MotionResourceManager
{
	static MOTIONMANAGER_LoadGMTDirect ASM_LoadGMTDirect;
	static MOTIONRESOURCEMANAGER_LoadMotionPar ASM_LoadPar;
	static MOTIONRESOURCEMANAGER_LoadMotionParToID ASM_LoadParToID;
	static MOTIONRESOURCEMANAGER_LoadMotionParWithID ASM_LoadParWithID;
	static MOTIONRESOURCEMANAGER_IsMotionParIDLoaded ASM_IsMotionParIDLoaded;
public:
	void* vfptr; //0x0000
	char pad_0008[19224]; //0x0008

	void LoadGMTDirect(unsigned int gmtID, int unknown, int heapCategory)
	{
		ASM_LoadGMTDirect(this, gmtID, unknown, heapCategory);
	}

	void LoadPar(char* path, int a1, int a2, int a3, int a4, int a5)
	{
		ASM_LoadPar(this, path, a1, a2, a3, a4, a5);
	}

	void LoadParToID(char* path, int ID, int a2, int a3)
	{
		ASM_LoadParToID(this, path, ID, a2, a3);
	}

	void LoadParWithID(int a1, int a2)
	{
		ASM_LoadParWithID(this, a1, a2);
	}

	bool IsMotionParIDLoaded(int id)
	{
		return ASM_IsMotionParIDLoaded(this, id);
	}

}; //Size: 0x4B20

class CActionMotionManager : public CActionBase
{
	static MOTIONMANAGER_LoadImportantResources ASM_LoadImportantResources;

public:
	char pad_01C8[8]; //0x01C8
	MotionResourceManager MotionResourceManager; //0x01D0
	CFileMotionProperty* fileProperty; //0x4CF0
	CFileBase* fileActionset; //0x4CF8
	char pad_4D00[24672]; //0x4D00

	void LoadImportantResources(bool isBattle)
	{
		ASM_LoadImportantResources(this, isBattle);
	}
}; //Size: 0xAD60