#include <iostream>

using namespace std;

#pragma region Snippets


// ctrl + k + c  Comment
// ctrl + k + u  Uncomment
// ctrl + a => ctrl + k + d Clean code

#pragma endregion 

int main()
{
#pragma region Cout 
	// cout << "Hello World"; // print("Hello World", end='')
	// cout << "Bye World";

	// cout << "Hello World" << '\n';
	// cout << "Bye World" << '\n';


	// cout << "Hello World" << endl; // endl = '\n'
	// cout << "Bye World" << endl;
#pragma endregion

#pragma region DataTypes


	/*
	 Integral data types
			int - 1						| bytes - 4 
			char - '1' ASCII			| bytes - 1
			bool - true(1) or false(0)	| bytes - 1
			short - 1					| bytes - 2
			long - 1					| bytes - 4
			long long - 1				| bytes - 8
			
	Floating data types
			float - 3.25				| bytes - 4
			double - 3.25				| bytes - 8
			
	Data types modifiers
			unsigned -	Без знака, то есть только положительные числа
			
			signed -
						Со знаком, все типы по умолчанию signed.
						Они могут быть как отрицательными, так и положительными

			const -		Значение по умолчанию, которое нельзя изменить.
						Сonst  всегда нужно инициализировать
	*/
	

#pragma endregion


	return 0;
}



