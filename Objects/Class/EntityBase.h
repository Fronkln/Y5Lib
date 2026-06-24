#pragma once
#pragma warning(suppress: 001)
#include "pch.h"

// Created with ReClass.NET 1.2 by KN4CK3R

#pragma pack(push, 1)
class EntityBase
{
public:
	char pad_0000[32]; //0x0000

	virtual void Destructor() {};
}; //Size: 0x0028

#pragma pack(pop)