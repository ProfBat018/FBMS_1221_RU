#include <iostream>
#include <string>
using namespace std;

// Polymorphism - способность сущности менять свое состояние. 
// Вода - 3 состояния. Жидкость, Пар, Лед
// override -  переопределить 

#pragma region Example1 

//class Employee  
//{
//public:
//	string name;
//	string surname;
//	int salary; 
//
//	virtual void work()
//	{
//		cout << "Abstract employee does something..." << endl;
//	}
//};
//
//class Driver : public Employee
//{
//public:
//	void work() override 
//	{
//		cout << "Driver drives a car..." << endl;
//	}
//};
//
//class Medic : public Employee
//{
//public:
//	void work() override 
//	{
//		cout << "Medic heals a person..." << endl;
//	}
//};


//int main()
//{
//	Employee* e = new Employee;
//
//	int selection;
//
//	cin >> selection;
//
//	e->work();
//
//	switch (selection)
//	{
//	case 1:
//		e = new Driver();
//		break;
//	case 2:
//		e = new Medic();
//		break;
//	}
//
//	e->work();
//
//	return 0;
//}
#pragma endregion

#pragma region Example2
/*
// Abstract Employee
class Employee  
{
public:
	string name;
	string surname;
	int salary; 

	virtual void work() = 0; // pure virtual method
};

class Driver : public Employee
{
public:
	void work() override 
	{
		cout << "Driver drives a car..." << endl;
	}
};

class Medic : public Employee
{
public:
	void work() override 
	{
		cout << "Medic heals a person..." << endl;
	}
};


int main()
{
	Employee* e = nullptr;

	int selection;

	cin >> selection;

	switch (selection)
	{
	case 1:
		e = new Driver();
		break;
	case 2:
		e = new Medic();
		break;
	}

	e->work();

	return 0;
}
*/

#pragma endregion


class Person
{
public:
	Person()
	{
		this->name = new char[] {"Subhi lubit spat))"};
	}

	~Person()
	{
		delete[] name;
	}

	char* name{};
};


int main()
{

	{
		Person* p = new Person();
	}

	return 0;
}


