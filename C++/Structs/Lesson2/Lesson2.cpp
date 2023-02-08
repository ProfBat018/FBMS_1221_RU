#include <iostream>
#include <string>

using namespace std;



enum Processor { Snapdragon, Exynos, MediaTech, Bionic };

struct phone
{
	char* make = new char[15]{};
	char* model = new char[15]{};
	uint16_t year;
	Processor cpu;
};

phone* create_phone()
{
	phone* new_phone = new phone();
	int choice{};

	cout << "Enter make: " << endl;
	cin.getline(new_phone->make, 15);

	cout << "Enter model: " << endl;
	cin.getline(new_phone->model, 15);

	cin.ignore();

	cout << "Enter year: " << endl;
	cin >> new_phone->year;

	cout 
		<< "Choose CPU: " << endl
		<< "1. Snapdragon" << endl
		<< "2. Exynos" << endl
		<< "3. MediaTech" << endl
		<< "4. Bionic";

	cin >> choice;
	cin.ignore();

	switch (choice - 1)
	{
	case Processor::Snapdragon:
		new_phone->cpu = Processor::Snapdragon;
		break;
	case Processor::Exynos:
		new_phone->cpu = Processor::Exynos;
		break;
	case Processor::MediaTech:
		new_phone->cpu = Processor::MediaTech;
		break;
	case Processor::Bionic:
		new_phone->cpu = Processor::Bionic;
		break;
	}

	return new_phone;
}
phone create_phone2()
{
	phone new_phone{};
	int choice{};

	cout << "Enter make: " << endl;
	cin >> new_phone.make;

	cout << "Enter model: " << endl;
	cin >> new_phone.model;

	cout << "Enter year: " << endl;
	cin >> new_phone.year;

	cout << "Choose CPU: " << endl;
	cin >> choice;

	switch (choice)
	{
	case Processor::Snapdragon:
		new_phone.cpu = Processor::Snapdragon;
		break;
	case Processor::Exynos:
		new_phone.cpu = Processor::Exynos;
		break;
	case Processor::MediaTech:
		new_phone.cpu = Processor::MediaTech;
		break;
	case Processor::Bionic:
		new_phone.cpu = Processor::Bionic;
		break;
	}
	return new_phone;
}


int main()
{
	phone* myPhone = create_phone();
	cout << myPhone->make;
	
	phone myPhone2 = create_phone2();
	cout << myPhone2.make;

	return 0;
}
