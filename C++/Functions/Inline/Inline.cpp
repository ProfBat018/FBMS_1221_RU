#include <iostream>
using namespace std;

void findEven(int arr[], const int length)
{
	for (size_t i = 0; i < length; i++)
	{
		if (arr[i] % 2 == 0)
		{
			cout << arr[i] << ' ';
		}
	}
}

float factorial(float num)
{
	if (num == 1)
	{
		return num;
	}
	return num * factorial(num - 1);
}


inline int add(int num1, int num2)
{
	return num1 + num2;
}

int main()
{

	//cout << factorial(5) << endl;

	//int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	//findEven(arr, 10);

	//int res = add(1, 2); // int res = 1 + 2 


	char arr[] = { "1234" };

	for (size_t i = 0; i < 5; i++)
	{
		cout << arr[i] << ' ';
	}

	return 0;
}
