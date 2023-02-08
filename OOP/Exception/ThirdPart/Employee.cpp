#include "Employee.h"
#include "Accountant.h"


Employee::Employee(string name, string surname, uint16_t age, uint16_t salary)
{
	this->name = name;
	this->surname = surname;
	this->age = age;
	this->salary = salary;
}


uint16_t Employee::getSalary()
{

}


void Employee::setSalary(uint16_t value)
{
	uint16_t previousSalary = this->salary;

	if (value < Accountant::min_salary)
	{
		throw exception("Low salary");
	}
	this->salary = value;
}
