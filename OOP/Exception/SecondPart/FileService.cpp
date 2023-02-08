#include "FileService.h"
#include <fstream>
#include <iostream>


void FileService::writeTo(string fileName, string data)
{
	ofstream input(fileName);
	input << data;

	if (input.bad() || input.fail())
	{
		throw exception("404");
	}
	else
	{
		input.close();
	}
}


string FileService::readFrom(string fileName)
{

	return "sdfgsd";
}
