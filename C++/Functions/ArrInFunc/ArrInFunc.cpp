#include <iostream>
#include "ArrInFunc.h"
using namespace std;

// Function declaration
// Прототип Функции

void print_arr(int, const int);
void fill_arr(int, const int);
void add_to_arr(int, const int, int);


int main()
{
	/*int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	
	print_arr(arr, 10);

	add_to_arr(arr, 10, 10);
	print_arr(arr, 10);*/

	const int size = 10;
	int arr[size]{};
	
	fill_arr(arr, size);

	print_arr(arr, size);

	return 0;
}



void print_arr(int arr[], const int length)
{
	for (size_t i = 0; i < length; i++)
	{
		cout << arr[i] << ' ';
	}
	cout << endl;
}

void fill_arr(int arr[], const int length)
{
	for (size_t i = 0; i < length; i++)
	{
		arr[i] = i + 1;
	}
}


void add_to_arr(int arr[], const int length, int number)
{
	for (size_t i = 0; i < length; i++)
	{
		arr[i] += number;
	}
}
