#include <iostream>

using namespace std;

template <typename T>
T* create_arr(unsigned int length, T type);

template <typename T>
void print_arr(int* arr, unsigned int length, T type);

template <typename T>
void append(T*& arr, unsigned int& length, T value);

int main()
{
	srand(time(0));

#pragma region Intro
	// int arr[5] = {1, 2, 3, 4, 5}; // Memory allocates while compile time

	// int* arr2 = new int(5); // new - who allocates memory in heap

	// cout << "Address: " << arr2 << ' ' << "Value: " << *arr2 << endl;

#pragma endregion
#pragma region HowToCreate
	//int length{};

	//cout << "Enter length of array";
	//cin >> length;

	//int* arr3 = new int[length] {};

	//for (size_t i = 0; i < length; i++)
	//{
	//	cout << "Enter: " << i + 1 << "element\n";
	//	cin >> *(arr3 + i);
	//}

	//for (size_t i = 0; i < length; i++)
	//{
	//	cout << i + 1 << "element: " <<  *(arr3 + i) << ' ';
	//}

#pragma endregion



	unsigned int length{};
	int type{};

	cout << "Enter length of array";
	cin >> length;

	int* arr = create_arr(length, type);
	print_arr(arr, length, type);
	
	cout << endl;
	
	append(arr, length, 666);
	print_arr(arr, length, type);

	return 0;
}

template <typename T>
T* create_arr(unsigned int length, T type)
{
	T* new_arr = new int[length] {};

	for (size_t i = 0; i < length; i++)
	{
		*(new_arr + i) = rand() % 10 + 1;
	}
	return new_arr;
}

template <typename T>
void print_arr(int* arr, unsigned int length, T type)
{
	for (size_t i = 0; i < length; i++)
	{
		cout << *(arr + i) << ' ';
	}
}

template <typename T>
void append(T*& arr, unsigned int& length, T value)
{
	T* tmp_arr = new T[length + 1]{};

	for (size_t i = 0; i < length; i++)
	{
		*(tmp_arr + i) = *(arr + i);
	}
	*(tmp_arr + length) = value;
	delete[] arr;
	arr = tmp_arr;
	length++;
}