#pragma once
#include <string>

using namespace std;


class FileService
{
public:
	static void writeTo(string fileName, string data);
	static string readFrom(string fileName);
};

