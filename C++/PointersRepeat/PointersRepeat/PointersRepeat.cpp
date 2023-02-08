#include <iostream>

using namespace std;


void print(int* arr, const int length)
{
	for (size_t i = 0; i < length; i++)
	{
		cout << *(arr + i) << ' ';
	}
	cout << endl;

}

void foo(int *arr, const int length)
{
	for (size_t i = 0; i < length; i++)
	{
		*(arr + i) = *(arr + i) + 10;
	}
}

void copy_to(int* original, int* destination, int length)
{
	for (size_t i = 0; i < length; i++)
	{
		*(destination + i) = *(original + i);
	}
}

void extend(int*& arr, int newLength)
{
	cout << arr << endl;
	int* tmp = new int[10]{};
	copy_to(arr, tmp, 10);


	arr = new int[newLength] {};
	copy_to(tmp, arr, 10);
}

int main()
{
	//int arr[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	//print(arr, 10);
	//foo(arr, 10);
	//print(arr, 10);


	int* arr = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	cout << arr << ' ' << &arr << endl;
	print(arr, 10);
	
	extend(arr, 20);

	print(arr, 20);


	return 0;
}
