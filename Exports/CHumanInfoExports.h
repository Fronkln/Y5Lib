#pragma once
#pragma once
#include "defines.h"
#include "Objects/Class/CHumanInfo.h"

extern "C"
{
	Y5LIB_EXPORT CHumanInfo* OE_LIB_HUMANINFO_GET(pxd_hash* hash)
	{
		return CHumanInfo::get_human_info(hash);
	}

	Y5LIB_EXPORT char* OE_LIB_HUMANINFO_GETTER_CHARACTER_NAME(CHumanInfo* cHumanInfo)
	{
		return cHumanInfo->characterName.string;
	}

	Y5LIB_EXPORT HumanInfo* OE_LIB_HUMANINFO_GETTER_DATA(CHumanInfo* cHumanInfo)
	{
		if (cHumanInfo == nullptr)
			return nullptr;

		return cHumanInfo->humanInfoData;
	}
}