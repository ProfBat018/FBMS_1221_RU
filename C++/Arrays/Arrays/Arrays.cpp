#include <iostream>


int main()
{
#pragma region OneDimensional
	// 1. data_type array_name[length];
	// 2. data_type array_name[length]{};
	// 3. data_type array_name[] = {1, 2, 3, 4, 5};

	// int arr[10]{};
	// std::cout << arr[0];

	/*int length = 10;
	int arr[length]{};*/
#pragma endregion
#pragma region MultiDimensional

	// int arr2[] = { 1, 2, 3, 4 };

	// int arr[][2] = { {1, 2}, {3, 4} };

	// std::cout << arr[0][0] << ' ' << arr[0][1] << std::endl;
	// std::cout << arr[1][0] << ' ' << arr[1][1] << std::endl;

	// std::cout << *(arr + 0) << ' ' << *(*arr + 0) << std::endl;
	// std::cout << *(arr + 1) << ' ' << *(*arr + 1) << std::endl;
	// std::cout << *(arr + 2) << ' ' << *(*arr + 2) << std::endl;
	// std::cout << *(arr + 3) << ' ' << *(*arr + 3) << std::endl;


#pragma endregion

	int number = 0;

	cin >> number;

	int arr[10]{};

	for (size_t i = 0; i < 10; i++)
	{
		std::cin >> arr[i];
	}

	for (size_t i = 0; i < 10; i++)
	{
		std::cout << arr[i] << ' ';
	}

	return 0;
}