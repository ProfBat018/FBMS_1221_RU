#include <iostream>

using namespace std;


int main()
{

#pragma region EndlessWhile
	//bool a{}; // {} - unified initialization C++ 11 

	//while (!a) // not a 
	//{
	//	cout << "Hello" << endl;
	//}

	/*while (not a)
	{
			cout << "Hello" << endl;
	}*/

#pragma endregion

#pragma region while_with_iteration

	/*
	int i{};

	while (i != 10)
	{
		cout << ++i << endl;
	*/

	//int i = 0;
	//int j = 0;

	//while (i != 4)
	//{
	//	while (j != 3)
	//	{
	//		cout << i << ' ' << ++j << endl;
	//		if (j == 3)
	//		{
	//			++i;
	//			j = 0;
	//			break;
	//		}
	//	}
	//}

#pragma endregion

#pragma region continue

	/*int num{ };

	while (num != 10)
	{
		cout << num;

		if (num == 5)
		{
			continue;
		}
		cout << ' ' << "Hello" << endl;
		++num;
	}*/

	/*int num{ };

	while (num != 10)
	{
		cout << ++num;

		if (num == 5)
		{
			continue;
		}
		cout << ' ' << "Hello" << endl;
	}*/
#pragma endregion


	/*int i = 0, j = ++i, k = ++j + ++i;


	cout << i << j << k;*/

	return 0;
}
