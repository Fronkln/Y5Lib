#include "CActionReactorManager.h"

REACTORMANAGER_CreateReactor CActionReactorManager::ASM_CreateReactor = (REACTORMANAGER_CreateReactor)(PatternScan("40 53 48 81 EC ? ? ? ? 48 8B 84 24 ? ? ? ? 48 8B D9 48 8B CA"));