#pragma once
#include "pch.h"

class FaceExpressionTarget
{
public:
	char pad_0000[136]; //0x0000
	float faceWeights[72]; //0x0088
	float mouthWeights[72]; //0x01A8
	float blendTime[72]; //0x02C8
}; //Size: 0x03E8

class CHumanDraw
{
public:
	void* vfptr; //0x0000
	char pad_0008[12]; //0x0008
	int32_t flags; //0x0014
	char pad_0018[28]; //0x0018
	int32_t heightIndex; //0x0034
	int32_t N000046E5; //0x0038
	int32_t N0000677A; //0x003C
	class pxd_hash modelName; //0x0040
	class pxd_hash modelName2; //0x0060
	char pad_0080[80]; //0x0080
	int32_t N000046F2; //0x00D0
	char pad_00D4[516]; //0x00D4
	class CHumanInfo* humanInfo; //0x02D8
	char pad_02E0[48]; //0x02E0
	FaceExpressionTarget faceExpressionTarget; //0x0310
	char pad_06F8[152]; //0x06F8
	class Human* owner; //0x0790
	char pad_0798[64]; //0x0798
	int32_t voicerID; //0x07D8
	char pad_07DC[36]; //0x07DC

	void SetExpressionWeight(int expression, float weight)
	{
		faceExpressionTarget.faceWeights[expression] = weight;
		faceExpressionTarget.mouthWeights[expression] = weight;
		faceExpressionTarget.blendTime[expression] = 0;
	}

	void SetFaceExpressionWeight(int expression, float weight)
	{
		faceExpressionTarget.faceWeights[expression] = weight;
		faceExpressionTarget.blendTime[expression] = 0;
	}

	void SetMouthExpressionWeight(int expression, float weight)
	{
		faceExpressionTarget.mouthWeights[expression] = weight;
		faceExpressionTarget.blendTime[expression] = 0;
	}

	void SetSingleExpressionWeight(int expression, float weight)
	{
		for (int i = 0; i < 72; i++)
		{
			if (i != expression)
				SetExpressionWeight(expression, 0);
		}

		SetExpressionWeight(expression, weight);
	}

	void SetSingleFaceExpressionWeight(int expression, float weight)
	{
		for (int i = 0; i < 72; i++)
		{
			if (i != expression)
				SetFaceExpressionWeight(expression, 0);
		}

		SetFaceExpressionWeight(expression, weight);
	}

	void SetSingleMouthExpressionWeight(int expression, float weight)
	{
		for (int i = 0; i < 72; i++)
		{
			if (i != expression)
				SetMouthExpressionWeight(expression, 0);
		}

		SetMouthExpressionWeight(expression, weight);
	}

}; //Size: 0x0800