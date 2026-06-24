#pragma once
#include "CSIXAXISListener.h"

class Fighter;

class FighterController : public CSIXAXISListener
{
public:
	class Fighter* fighter; //0x0020
	char pad_0028[16]; //0x0028
};