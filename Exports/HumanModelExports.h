#pragma once
#include "defines.h"
#include "Objects/Class/CHumanDraw.h"

extern "C"
{
	Y5LIB_EXPORT inline Human* OE_LIB_CHUMANDRAW_GETTER_OWNER(CHumanDraw* model)
	{
		if (model == nullptr)
			return 0;

		return model->owner;
	}

	Y5LIB_EXPORT inline const char* OE_LIB_CHUMANDRAW_GETTER_MODELNAME(CHumanDraw* model)
	{
		if (model == nullptr)
			return 0;

		return model->modelName.string;
	}

	Y5LIB_EXPORT inline int OE_LIB_CHUMANDRAW_GETTER_FLAGS(CHumanDraw* model)
	{
		if (model == nullptr)
			return 0;

		return model->flags;
	}


	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SETTER_FLAGS(CHumanDraw* model, int flags)
	{
		if (model == nullptr)
			return;

		model->flags = flags;
	}

	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SET_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID, float weight)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return;

		exp->SetExpressionWeight(expressionID, weight);
	}

	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SET_FACE_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID, float weight)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return;

		exp->SetFaceExpressionWeight(expressionID, weight);
	}

	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SET_MOUTH_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID, float weight)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return;

		exp->SetMouthExpressionWeight(expressionID, weight);
	}

	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SET_SINGLE_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID, float weight)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return;

		exp->SetSingleExpressionWeight(expressionID, weight);
	}

	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SET_SINGLE_FACE_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID, float weight)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return;

		exp->SetSingleFaceExpressionWeight(expressionID, weight);
	}

	Y5LIB_EXPORT inline void OE_LIB_CHUMANDRAW_SET_SINGLE_MOUTH_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID, float weight)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return;

		exp->SetSingleMouthExpressionWeight(expressionID, weight);
	}

	Y5LIB_EXPORT inline float OE_LIB_CHUMANDRAW_GET_FACE_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return 0;

		return exp->faceExpressionTarget.faceWeights[expressionID];
	}

	Y5LIB_EXPORT inline float OE_LIB_CHUMANDRAW_GET_MOUTH_EXPRESSION_WEIGHT(CHumanDraw* exp, int expressionID)
	{
		if (exp == nullptr || expressionID < 0 || expressionID >= 72)
			return 0;

		return exp->faceExpressionTarget.mouthWeights[expressionID];
	}
}