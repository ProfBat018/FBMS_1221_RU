#include <iostream>
#include "CharLib.h"

int main()
{
	char* name = new char[] {"Elvin"};
	char* surname = new char[] {"Azimov"};

	std::cout << name << std::endl;
	append(name, surname);
	std::cout << name << std::endl;

	return 0;
}
