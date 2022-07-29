#include <iostream>

using namespace std;

#pragma region FirstPart


//
//void foo()
//{
//	cout << "Hello World" << endl;
//}
//
//
//int power(int num1, int num2)
//{
//	int res = 1;
//	for (size_t i = 0; i < num2; i++)
//	{
//		res *= num1;
//	}
//	return res;
//}
//
//
//
//unsigned short getLength(char* data)
//{
//	unsigned short length = 0;
//	int i = 0;
//
//	while (*(data + i) != '\0')
//	{
//		i++;
//		length++;
//	}
//	return length;
//}
//
//unsigned short (*length_ptr)(char*) = getLength;
//
//void copy_data(char* original, char* destination)
//{
//	auto len = length_ptr(original);
//
//	for (size_t i = 0; i < len; i++)
//	{
//		*(destination + i) = *(original + i);
//	}
//	*(destination + len) = 0;
//}
//
//void append(char*& data, char*& new_data)
//{
//	auto old_len = length_ptr(data);
//	auto new_len = old_len + length_ptr(new_data);
//
//	char* old_copy = new char[old_len] {};
//	copy_data(data, old_copy);
//
//	delete[] data;
//	data = new char[new_len] {};
//	copy_data(old_copy, data);
//
//	for (size_t i = old_len, j = 0; i < new_len; i++, ++j)
//	{
//		*(data + i) = *(new_data + j);
//	}
//	*(data + new_len) = 0;
//}
//
//
//
//void foo1(int n1, int n2)
//{
//	cout << "Foo1" << endl;
//}
//
//void foo2(int n1, int n2)
//{
//	cout << "Foo2" << endl;
//}
//
//void foo3(int n1, int n2)
//{
//	cout << "Foo3" << endl;
//}
//
//void foo4(int n1, int n2)
//{
//	cout << "Foo4" << endl;
//}
//
//int main()
//{
//	void(*foo_funcs[])(int, int) = {foo1, foo2, foo3, foo4};
//
//	/*for (size_t i = 0; i < 4; i++)
//	{
//		for (size_t j = 0; j < 3; j++)
//		{
//			foo_funcs[i](j, j + 1);
//		}
//	}*/
//
//	//int k;
//	//cin >> k;
//	//
//	//foo_funcs[k - 1](1, 1);
//
//
//
//
//	
//	return 0;
//}

#pragma endregion


#pragma region Part2 

float countSalary(float salary)
{
	float result{};

	result = salary - salary * 0.05 - 75 - 12;
}

float newCountSalary(float salary);


int main()
{
	float(*salary_ptr)(float) = newCountSalary;
	
	countSalary(4000);

	return 0;
}

#pragma endregion

