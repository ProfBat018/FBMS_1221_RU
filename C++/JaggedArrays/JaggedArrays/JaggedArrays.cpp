#include <iostream>

int main()
{
	const int cols = 3;
	const int rows = 2;

	int** arr = new int* [cols] {};

	for (size_t i = 0; i < 3; i++)
	{
		*(arr + i) = new int[rows] {};
	}



	std::cout
		<< "Address of ptr in STACK: " << &arr << std::endl
		<< "First element of *arr: " << *(arr + 0) << std::endl
		<< "Second element of *arr: " << *(arr + 1) << std::endl
		<< "First element of First ROW: " << **(arr + 0) << std::endl
		<< "First element of Second ROW: " << **(arr + 1) << std::endl
		<< "Second element of First ROW: " << *(*(arr + 0) + 1) << std::endl
		<< "Second element of Second ROW: " << *(*(arr + 1) + 1) << std::endl;


	return 0;
}

