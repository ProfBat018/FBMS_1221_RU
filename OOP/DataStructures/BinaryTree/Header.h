#pragma once
#include <iostream>


struct Node
{
	Node()
	{
		std::cout << "From another header";
	}
};