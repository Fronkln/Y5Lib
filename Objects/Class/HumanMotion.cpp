#include "HumanMotion.h"

HumanMotion_SetPosition Motion::HumanMotion::ASM_SetPosition = (HumanMotion_SetPosition)PatternScan("40 53 48 83 EC ? C5 F8 10 02 C5 F8 11 41 50");