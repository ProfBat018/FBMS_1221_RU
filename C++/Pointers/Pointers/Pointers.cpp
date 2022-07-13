#include <iostream>

using namespace std;

// постоянная память - HHD, SSD, SSHD
// временная память - RAM
// RAM - random access memory
// 1 process contains from several threads
// 1 thread - 1 stack
// Stack - Дефрагментированная область памяти.
// Heap - Расширяемая неупорядоченная область памяти. 

int main()
{
 #pragma region Part1
	// int number = 5; // variable, 4 byte data type int

	// Pointer - variable, which contains int stack
	// x64 - 8 byte
	// x32 - 4 byte

	// int* ptr_number = &number;

#pragma endregion

#pragma region Part2

	// int num = 5;
	//
	// int* ptr = &num;
	//
	// cout
	// << "Address of pointer: " << &ptr << '\n'
	// << "Value of pointer: " << ptr << '\n'
	// << "Dereference of value of pointer: " << *ptr << '\n';

#pragma endregion

#pragma region Part3

	// Pointer arithmetic
	/*int arr[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	for (int i = 0; i < 10; i++)
	{
		cout
			<< "Address: " << arr + i << ' ' << "Value: " << *(arr + i) << '\n';
	}*/

#pragma  enregion
	return 0;
}
