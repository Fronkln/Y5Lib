#pragma once
#include "defines.h"
#include "Objects/Class/FighterController.h"

extern "C"
{
    Y5LIB_EXPORT inline Fighter* OE_LIB_FIGHTERCONTROLLER_GETTER_FIGHTER(FighterController* cont)
    {
        if (cont == nullptr)
            return nullptr;

        return cont->fighter;
    }
}