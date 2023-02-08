#include "Car.h"
#include "Showroom.h"


int menu() {

	Showroom* sw = new Showroom(); // создание автосалона 
	Showroom* sw2 = new Showroom(); // создание автосалона 
	int selection{};

	// добавление машин в автосалон, чтобы не делать это в консоли каждый раз
	sw->cars[0] = *(new Car(new char[] {"Mercedes"}, new char[] {"C200"}, 2000, 2000, 136));
	sw->free_place--; // вручную уменбшаю свободное место после добавления.

	sw->cars[1] = *(new Car(new char[] {"Chevy"}, new char[] {"Cruze"}, 2017, 1400, 153));
	sw->free_place--;

	sw->cars[2] = *(new Car(new char[] {"BMW"}, new char[] {"M6"}, 2014, 4400, 550));
	sw->free_place--;



	while (true)
	{
		std::cout
			<< "1. Add car" << std::endl
			<< "2. Edit car" << std::endl
			<< "3. Delete car" << std::endl
			<< "4. Show all" << std::endl
			<< "5. Show car" << std::endl
			<< "6. Update capacity" << std::endl
			<< "7. Exit" << std::endl
			<< "ENTER YOUR CHOICE: " << std::endl;

		std::cin >> selection;

		switch (selection)
		{
		case 1:
			sw->addCar();
			system("cls");
			break;
		case 2:
			sw->editCar();
			system("cls");
			break;
		case 3:
			sw->deleteCar();
			system("cls");
			break;
		case 4:
			sw->showAll();
			system("cls");
			break;
		case 5:
			sw->showCar();
			system("cls");
			break;
		case 6:
			sw->updateCapacity();
			system("cls");
			break;
		case 7:
			return 0;
		}
	}
}