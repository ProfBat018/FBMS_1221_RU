#include <iostream>
#include "CharLib.h"


unsigned short getLength(char* data)
{
	unsigned short length = 0;
	int i = 0;

	while (*(data + i) != '\0')
	{
		i++;
		length++;
	}
	return length;
}

void copy_data(char* original, char* destination)
{
	auto len = getLength(original);

	for (size_t i = 0; i < len; i++)
	{
		*(destination + i) = *(original + i);
	}
	*(destination + len) = 0;
}

void append(char*& data, char*& new_data)
{
	auto old_len = getLength(data);
	auto new_len = old_len + getLength(new_data);

	char* old_copy = new char[old_len] {};
	copy_data(data, old_copy);
	
	delete[] data;
	data = new char[new_len] {};
	copy_data(old_copy, data);

	for (size_t i = old_len, j = 0; i < new_len; i++, ++j)
	{
		*(data + i) = *(new_data + j);
	}
	*(data + new_len) = 0;
}
