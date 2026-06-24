#pragma once
class pxd_hash
{
public:
	short checksum; //0x0000
	char string[30]; //0x0002

	void set(const char* inputStr)
	{
		strcpy_s(string, 30, inputStr);

		checksum = 0;

		for (int i = 0; i < strlen(inputStr); i++)
			checksum += (BYTE)inputStr[i];
	}
}; //Size: 0x0020