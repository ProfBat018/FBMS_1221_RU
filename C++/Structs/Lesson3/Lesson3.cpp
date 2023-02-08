#include <iostream>
using namespace std;

struct phone
{
	enum processor { Exynos, Snapdragon, MediaTec, Bionic }; // definition of data type

	char* make{};
	char* model{};
	uint16_t RAM{};
	processor cpu{}; // usage of data type
}*maga;


char* write_phone(phone* p)
{
	char* make = p->make;
	char* model = p->model;
	char* ram = new char[2] {};
	_itoa_s(p->RAM, ram, 3, 10);
	char* result = new char[1024] {};

	int i = 0;
	for (int j = 0; i < strlen(make); ++i, ++j)
	{
		result[i] = make[j];
	}
	result[i] = ' ';
	++i;


	for (int j = 0; j < strlen(model); ++i, ++j)
	{
		result[i] = model[j];
	}
	result[i] = ' ';
	++i;

	for (int j = 0; j < strlen(ram); ++i, ++j)
	{
		result[i] = ram[j];
	}
	return result;
}

int main()
{
	// phone* p1 = new phone{ new char[] {"Iphone"}, new char[] {"13"}, 4, phone::Bionic };
	//
	// FILE* file;
	//
	// fopen_s(&file, "data.txt", "w");
	//
	// if (file)
	// {
	// 	fputs(write_phone(p1), file);
	// }
	//
	// if (file)
	// {
	// 	fclose(file);
	// }


	FILE* file;

	fopen_s(&file, "C:\\data.txt", "r");

	char* buffer = new char[1024] {};

	fgets(buffer, 1024, file);

	cout << buffer;

	return 0;
}
