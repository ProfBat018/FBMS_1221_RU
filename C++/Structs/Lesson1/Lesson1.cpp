#include <iostream>
#include <string>
using namespace std;

// Структура - описание сущности !
// Переменные структуры - это поля(field) !

struct Car // Struct - user defined data type 
{
	char* make = new char[30]{};
	char* model = new char[30]{};
	uint16_t year{};

	Car() // Constructor, Default constructor
	{
		cout << "Enter make: " << endl;
		cin.getline(make, 30);
		cout << "Enter model: " << endl;
		cin.getline(model, 30);
		cout << "Enter year: " << endl;
		cin >> year;
		cin.ignore();
	}

	Car(char* make, char* model, uint16_t year)
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


int main()
{
	Car* cars = new Car[2]{};

	for (size_t i = 0; i < 2; i++)
	{
		cars[i].print();
	}

	//Car c1; // При создании объекта типа Car, неявно вызывается конструктор по усолчанию(Default constructor) 

	//c1.print();



	return 0;
}

