#pragma once
#include "defines.h"
#include "Objects/Class/HumanModel.h"

extern "C"
{
	Y5LIB_EXPORT inline const char* OE_LIB_HUMANMODEL_GETTER_MODELNAME(HumanModel* model)
	{
		if (model == nullptr)
			return 0;

		return model->modelName.string;
	}
}