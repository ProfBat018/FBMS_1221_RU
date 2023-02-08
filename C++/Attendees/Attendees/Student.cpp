#include <iostream>
#include "Student.h"

using namespace std;

Student* create_student()
{
	Student* tmp = new Student();
	unsigned short total{};

	cout << "Enter name of Student: ";
	cin >> tmp->name;

	cout << "Enter surname of Student: ";
	cin >> tmp->surname;

	cout << "Enter age of Student: ";
	cin >> tmp->age;

	cout << "Enter grades: " << endl;

	for (size_t i = 0; i < grade_count; i++)
	{
		cout << i + 1 << ": ";
		cin >> tmp->grades[i];
	}

	for (size_t i = 0; i < grade_count; i++)
	{
		total += tmp->grades[i];
	}

	tmp->gpa = total / grade_count;
	system("cls");

	return tmp;
}

void print_student(Student* student)
{
	cout
		<< "Name is: " << student->name << endl
		<< "Surname is: " << student->surname << endl
		<< "Age is: " << student->age << endl;

	for (size_t i = 0; i < grade_count; i++)
	{
		cout << i + 1 << '.' << "grade = " << student->grades[i] << endl;
	}
	cout << "Gpa: " << student->gpa << endl;
}
