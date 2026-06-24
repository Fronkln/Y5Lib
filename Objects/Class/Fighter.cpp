#include "Fighter.h"
#include "PatternScan.h"

FIGHTER_ToDead Fighter::ASM_ToDead = (FIGHTER_ToDead)PatternScan("48 83 EC ? 8B 91 ? ? ? ? 0F BA E2 ? 73");