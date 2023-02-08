#pragma once
#include  <iostream>

struct Car
{
	char* make = new char[25]{};
	char* model = new char[25]{};
	uint16_t year{};	
	uint16_t volume{};
	uint16_t HP{};

	void print(); // method. Method - функция, которая вызывается от имени объекта. 

	Car(); // ctor without params. Default ctor
	Car(char*, char*, uint16_t, uint16_t, uint16_t); // Ctor with params 
};


Car* create_car();
