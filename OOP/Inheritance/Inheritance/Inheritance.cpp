#include <iostream>
#include <string>

using namespace std;

class Person
{
public:
	Person() = default;

	Person(string name, string surname, uint16_t age)
	{
		this->name = name;
		this->surname = surname;
		this->age = age;
	}
private:
	string name{};
	string surname{};
	uint16_t age{};
};


class Employee : public Person
{
public:
	Employee() = default;

	Employee(uint16_t salary)
	{
		this->salary = salary;
	}

	Employee(string name, string surname, uint16_t age, uint16_t salary) : Person(name, surname, age) // делегирование конструкторов
	{
		this->salary = salary;
	}
private:
	uint16_t salary;
};


int main()
{
	Employee emp("Elvin", "Azimov", 20, 20000);


	return 0;	
}
