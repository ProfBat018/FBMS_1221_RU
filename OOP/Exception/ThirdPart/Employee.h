#pragma once
#include <iostream>

using namespace std;

struct Employee
{
private:
	string name{};
	string surname{};
	uint16_t age{};
	uint16_t salary{};
public:
	Employee(string, string, uint16_t, uint16_t);
	uint16_t getSalary();
	void setSalary(uint16_t);
};

