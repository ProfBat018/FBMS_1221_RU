#include <iostream>
#include "Car.h"
#include <string>

Car::Car() = default;

Car::Car(char* make, char* model, uint16_t year, uint16_t volume, uint16_t HP)
{
	this->make = make;
	this->model = model;
	this->year = year;
	this->volume = volume;
	this->HP = HP;
}

void Car::print()
{
	std::cout
		<< "Make: " << this->make << std::endl
		<< "Model: " << this->model << std::endl
		<< "Year: " << this->year << std::endl
		<< "Volume: " << this->volume << std::endl
		<< "HP: " << this->HP << std::endl;
}


Car* create_car()
{
	Car* tmp = new Car(); // Создаю Car в Heap

	std::cin.ignore();

	std::cout << "Enter make of car: " << std::endl;
	std::cin.getline(tmp->make, 25);

	std::cout << "Enter model of car: " << std::endl;
	std::cin.getline(tmp->model, 25);

	std::cout << "Enter year of car: " << std::endl;
	std::cin >> tmp->year;

	std::cout << "Enter volume of car: " << std::endl;
	std::cin >> tmp->volume;

	std::cout << "Enter HP of car: " << std::endl;
	std::cin >> tmp->HP;

	system("cls");
	return tmp;
}

