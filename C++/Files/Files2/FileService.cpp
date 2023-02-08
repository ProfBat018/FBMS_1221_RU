#include "FileService.h"

void FileService::writeToFile(const char* name, const char* mode)
{
	FILE* file;

	fopen_s(&file, name, mode);

	char* buffer = new char[1024] {"Hello"};

	if (mode[0] == 'w')
	{
		fputs(buffer, file);
	}
	else if (mode[0] == 'r')
	{
		fgets(buffer, 1024, file);
	}
}
