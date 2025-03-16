#include "CLiveBtlPlayer.h"

CLiveBtlPlayer** CLiveBtlPlayer::Current = (CLiveBtlPlayer**)resolve_relative_addr(PatternScan("4C 8D 35 ? ? ? ? 33 DB C5 F8 29 74 24 40"));
