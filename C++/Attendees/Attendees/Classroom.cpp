#include <iostream>
#include "Classroom.h"

using namespace std;

Classroom* tmp = new Classroom();

Classroom* create_class()
{
	Classroom* tmp = new Classroom();

	cout << "Enter name of class: ";
	cin >> tmp->class_name;

	cout << "Enter student count: ";
	cin >> tmp->students_count;

	if (tmp->students_count != 2)
	{
		tmp->students = new Student[tmp->students_count]{};
	}

	for (int i = 0; i < tmp->students_count; ++i)
	{
		tmp->students[i] = *create_student();
	}
	return tmp;
}

void print_class(Classroom* classroom)
{
	cout
		<< "Name: " << classroom->class_name << endl
		<< "Student count: " << classroom->students_count << endl
		<< "Students: " << endl;

	for (int i = 0; i < classroom->students_count; ++i)
	{
		print_student(&classroom->students[i]);
	}
}

