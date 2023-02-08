#include <iostream>
#include <string>
using namespace std;

// Структура - описание сущности !
// Переменные структуры - это поля(field) !

struct car // Struct - user defined data type 
{
	char* make = new char[30]{};
	char* model = new char[30]{};
	uint16_t year{};

	car() // Constructor, Default constructor
	{
		cout << "Enter make: " << endl;
		cin.getline(make, 30);
		cout << "Enter model: " << endl;
		cin.getline(model, 30);
		cout << "Enter year: " << endl;
		cin >> year;
		cin.ignore();
	}

	car(char* make, char* model, uint16_t year)
	{
		this->make = make;
		this->model = model;
		this->year = year;
	}

	void print() // Method
	{
		cout << this->make << ' ' << this->model << ' ' << this->year << '\n';
	}
};


void foo(int (*test)(int, int), int num1, int num2)
{
	int result = test(num1, num2);
	cout << result;
}

int add(int num1, int num2)
{
	return num1 + num2;
}

int foo2(int n1, int n2)
{
	return n1 * 2 + n2 + n1;
}

int main()
{
	foo(add, 1, 2);
	foo(foo2,1, 2);

	/*Car* cars = new Car[2]{};

	for (size_t i = 0; i < 2; i++)
	{
		cars[i].print();
	}*/

	//Car c1; // При создании объекта типа Car, неявно вызывается конструктор по усолчанию(Default constructor) 

	//c1.print();



	return 0;
}

