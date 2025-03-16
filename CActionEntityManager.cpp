#include "CActionEntityManager.h"

CActionEntityManager::_GetEntityByUID CActionEntityManager::ASM_GetEntityByUID = (CActionEntityManager::_GetEntityByUID)(PatternScan("48 83 EC ? 4C 8D 81 40 10 01 00"));