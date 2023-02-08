#include <iostream>
using namespace std;


int main()
{
#pragma region Part1
	/*
	int selection = 0;

	while (true)
	{
		cout << "Enter your choice:\n"
			<< "1. Addition\n"
			<< "2. Subtraction\n"
			<< "3. Multiplication\n"
			<< "4. Divison\n";

		cin >> selection;

		switch (selection)
		{
		case 1:
			cout << 1 << endl;
			break;
		case 2:
			cout << 2 << endl;
			break;
		case 3:
			cout << 3 << endl;
			break;
		case 4:
			cout << 4 << endl;
			break;
		default:
			cout << "Error choice" << endl;
			break;
		}

	}
	*/
#pragma endregion

#pragma region ENUM
/*
	enum Selections {ADDITION = 1, SUBTRACTION, MULTIPLICATION, DIVISION};
	
	int selection = 0;

	while (true)
	{
		cout << "Enter your choice:\n"
			<< "1. Addition\n"
			<< "2. Subtraction\n"
			<< "3. Multiplication\n"
			<< "4. Divison\n";

		cin >> selection;

		switch (selection)
		{
		case Selections::ADDITION:
			cout << "Addition" << endl;
			break;
		case Selections::SUBTRACTION:
			cout << "Subtraction" << endl;
			break;
		case Selections::MULTIPLICATION:
			cout << "Multiplication" << endl;
			break;
		case Selections::DIVISION:
			cout << "Division" << endl;
			break;
		default:
			cout << "Error choice" << endl;
			break;
		}
	}
*/


#pragma endregion

#pragma region IntegralTypes

	/*int a = 3.25;

	const int n1 = 1;
	const int n2 = 2;
	const int n3 = 3;

	switch (a)
	{
	case n1:
		break;
	case n2:
		break;
	case n3:
		break;
	}*/


#pragma endregion


	return 0;
}
