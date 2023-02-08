#pragma once
#include <string>
#include "Employee.h"

using namespace std;

class Accountant // Бухгалтер
{
public:
	static const uint16_t min_salary;
	void countSalary(Employee&);
	void countAward(Employee&);
	Accountant(uint16_t, uint16_t, uint16_t);
private:
	uint16_t insurance_tax{};
	uint16_t social_tax{};
	uint16_t gov_tax{};
};

