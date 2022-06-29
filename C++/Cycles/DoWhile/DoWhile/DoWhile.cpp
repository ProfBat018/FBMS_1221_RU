#include <iostream>

using namespace std;

int main()
{
	int selection = 0, check = 1;

	system("color 03");
	do
	{
		cout
			<< "1. Addition" << '\n'
			<< "2. Subtraction" << '\n'
			<< "3. Exit" << '\n';
		cin >> selection;

		switch (selection)
		{
		case 1:
			cout << "addition" << '\n';
			break;
		case 2:
			cout << "subtraction" << '\n';
			break;
		case 3:
			check = false;
		}
	} while (check);

}
