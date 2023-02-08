#include "Accountant.h"

const uint16_t Accountant::min_salary = 300;

void Accountant::countSalary(Employee& emp)
{
	emp.setSalary(emp.getSalary() - (this->gov_tax * emp.getSalary() / 100));
	emp.setSalary(emp.getSalary() - this->insurance_tax);
	emp.setSalary(emp.getSalary() - this->social_tax);
}


void Accountant::countAward(Employee& emp)
{

}
