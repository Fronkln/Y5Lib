#include "CScenarioManager.h"
#include "PatternScan.h"

CSCENARIOMANAGER_LoadPlayerPos CScenarioManager::ASM_LoadPlayerPos = (CSCENARIOMANAGER_LoadPlayerPos)PatternScan("48 89 5C 24 ? 48 89 74 24 ? 57 48 83 EC ? 45 85 C0");
CSCENARIOMANAGER_LoadScenario CScenarioManager::ASM_LoadScenario = (CSCENARIOMANAGER_LoadScenario)PatternScan("48 89 5C 24 ? 57 48 83 EC ? 48 8B F9 8B DA 48 8B 49 ? E8 ? ? ? ? 48 85 C0");