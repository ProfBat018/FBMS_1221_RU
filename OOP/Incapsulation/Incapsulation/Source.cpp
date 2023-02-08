
// struct 
// class 

#pragma region AccessModifiers

#include <iostream>

// Access Modifiers - 3
// private - Все элементы доступны только внутри класса
// public - В структурах по умолчанию. То есть Все элементы доступны везде.
// protected - Доступен только в наследниках и в самом классе. 


struct Teacher
{
public:
	Teacher() = default; // deafault ctor

	uint16_t get_salary() const // getter 
	{
		return this->salary - (this->salary * 0.05); 
	}

	void set_salary(uint16_t salary) // setter
	{
		this->salary = salary;
	}
private:
	char* name{};
	char* surname{};
	uint16_t age{};
	uint16_t salary{};

};



int main() {

	Teacher t;


	return EXIT_SUCCESS;
}

#pragma endregion
