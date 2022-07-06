#include <iostream>
using namespace std;

#pragma region Part1
/*
int addition(int, int);
float addition(float, float);
double addition(double, double);


int main()
{
	cout << addition(1, 2);
	cout << addition(1.f, 2.f);
	cout << addition(1., 2.);


	return 0;
}

int addition(int num1, int num2)
{
	return num1 + num2;
}
float addition(float num1, float num2)
{
	return num1 + num2;
}
double addition(double num1, double num2)
{
	return num1 + num2;
}
*/
#pragma endregion

#pragma region OverloadingTypes

// By parameter type

/*
void foo(int num)
{
	cout << num;
}
void foo(float num)
{
	cout << num;
}
*/

// By count
/*
void foo(int num1)
{
	cout << num1;
}
void foo(int num1, int num2)
{
	cout << num1 << ' ' << num2;
}
*/

// By sequence
/*

void foo(int num1, float num2)
{
	cout << "First" << endl;
}

void foo(float num1, int num2)
{
	cout << "Second" << endl;
}
*/


int main()
{


	return 0;
}

#pragma endregion

