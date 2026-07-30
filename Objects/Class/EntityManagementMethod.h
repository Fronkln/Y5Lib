#pragma once
#include "CActionBase.h"

class Entity;
class CCCEntityEntry;

class EntityManagementMethod : public CActionBase
{
public:
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
	virtual void Func23() {};
	virtual void Func24() {};
	virtual void Func25() {};
	virtual void Func26() {};
	virtual void Func27() {};
	virtual void Func28() {};
	virtual void Func29() {};
	virtual void Func30() {};
	virtual Entity* CreateEntity(CCCEntityEntry* entry);
	virtual bool DestroyEntity(Entity* entity);
};