#pragma once
#include <iostream>
#include <string>

using namespace std;

class OutOfRangeException : public std::exception
{
public:
	OutOfRangeException(uint16_t size, uint16_t offset)
	{
		this->size = size;
		this->offset = offset;
	}

	char const* what() const override 
	{
		char* _size = new char[10];
		char* _offset = new char[10];

		_itoa_s(size, _size, 10, 10);
		_itoa_s(offset, _offset, 10, 10);

		string* res =  new string();
		
		res->append("Out Of Range Exception...\n");
		res->append("Size is:\n");
		res->append(_size);
		res->append("\n");
		res->append("Offset is:\n");
		res->append(_offset);

		return res->c_str();
	}

	uint16_t size{};
	uint16_t offset{};

};