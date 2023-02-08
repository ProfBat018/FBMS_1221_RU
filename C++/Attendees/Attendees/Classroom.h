#pragma once
#include <iostream>
#include "Student.h"

using namespace std;

struct Classroom
{
	unsigned short students_count{2};
	Student* students = new Student[students_count]{};
	char* class_name = new char[15] {};
};

Classroom* create_class();
void print_class(Classroom*);