#pragma once

struct Person
{
	Person()
	{

	}
	static int _id;

	int id = ++_id;
	char* name{};
};

int Person::_id = 0;
