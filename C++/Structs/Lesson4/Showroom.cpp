#include "Showroom.h"
#include "Car.h"
#include <iostream>

int select_car(Showroom* showroom)
{
	showroom->showAll();

	uint16_t selection{};
	std::cout << "Enter car index: ";
	std::cin >> selection;
	system("cls");

	return selection - 1;
}


void Showroom::addCar()
{
	std::cout << " There are: " << this->free_place << " free places " << std::endl;
	this->cars[this->capacity - this->free_place] = *create_car();
	this->free_place--;
}


void Showroom::editCar()
{
	int index = select_car(this);

	bool check = true;

	while (check)
	{
		int selection{};

		system("cls");

		std::cout
			<< "1. Make" << std::endl
			<< "2. Model" << std::endl
			<< "3. Year" << std::endl
			<< "4. Exit" << std::endl;

		std::cin >> selection;

		switch (selection)
		{
		case 1:
			std::cout << "Enter new Make: ";
			std::cin.getline(this->cars[index].make, 25);
			break;
		case 2:
			std::cout << "Enter new Model: ";
			std::cin.getline(this->cars[index].model, 25);
			break;
		case 3:
			std::cout << "Enter new Year: ";
			std::cin >> this->cars[index].year;
			break;
		case 4:
			check = false;
			break;
		default:
			std::cout << "Make a right choice..." << std::endl;
		}
	}
}


void Showroom::showAll()
{
	std::cout << "Current capacity is: " << this->capacity << std::endl;

	if (!(this->capacity - this->free_place))
		std::cout << "No cars yet..." << std::endl;

	for (int i = 0; i < this->capacity - this->free_place; ++i)
	{
		std::cout
			<< i + 1 << ". " << this->cars[i].make << ' ' << this->cars[i].model << std::endl;
	}
	std::cout << "Press any key to exit from this menu...." << std::endl;
	std::cin.ignore();
	std::cin.get();
}

void Showroom::showCar()
{
	int index = select_car(this);
	this->cars[index].print();
	std::cout << "Press any key to exit from this menu...." << std::endl;
	std::cin.ignore();
	std::cin.get();
	system("cls");
}


void Showroom::deleteCar()
{
	Car* tmp_cars = new Car[this->capacity]{};

	int index = select_car(this);

	if (index < (this->capacity - this->free_place) - 1)
	{
		for (int i = 0, j = 0; i < this->capacity - this->free_place && j < this->capacity - this->free_place; ++i, ++j)
		{
			if (j == index)
			{
				++j;
			}
			tmp_cars[i] = this->cars[j];
		}
	}
	else {
		this->deleteCar();
	}
	delete[] this->cars;

	this->free_place++;

	this->cars = new Car[this->capacity]{};

	for (int i = 0; i < (this->capacity - this->free_place); ++i)
	{
		this->cars[i] = tmp_cars[i];
	}
	delete[] tmp_cars;
}

void Showroom::updateCapacity()
{
	uint16_t new_capacity{};
	std::cout << "Enter new capacity: ";
	std::cin >> new_capacity;

	if (new_capacity >= this->capacity - this->free_place)
	{
		Car* tmp_cars = new Car[new_capacity];
		uint16_t count = 0;

		for (size_t i = 0; i < this->capacity - this->free_place; i++)
		{
			tmp_cars[i] = this->cars[i];
			count++;
		}

		delete[] this->cars;

		this->capacity = new_capacity;

		this->cars = new Car[new_capacity];

		for (size_t i = 0; i < count; i++)
		{
			this->cars[i] = tmp_cars[i];
		}
		this->free_place = this->capacity - count;

		delete[] tmp_cars;
	}
	else {
		this->updateCapacity();
	}
}