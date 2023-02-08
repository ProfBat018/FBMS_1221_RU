#pragma once
#include "Car.h"

struct Showroom
{
	uint16_t free_place = 5;
	uint16_t capacity = 5;
	Car* cars = new Car[capacity]{};

	void addCar();
	void editCar();
	void deleteCar();
	void showAll();
	void showCar();
	void updateCapacity();
};
