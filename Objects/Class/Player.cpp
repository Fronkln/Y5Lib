#include "Player.h"
#include "PatternScan.h"
#include "MemoryMgr.h"
PLAYER_GET_CURRENT_ID Player::ASM_GetCurrentID = (PLAYER_GET_CURRENT_ID)Memory::ReadCall2(PatternScan("E8 ? ? ? ? 48 63 8F ? ? ? ? 83 F9"));