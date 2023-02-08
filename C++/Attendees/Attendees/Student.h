#pragma once

const int grade_count = 5;

struct Student
{
	char* name = new char[30]{};
	char* surname = new char[30];
	unsigned short age{};
	int grades[grade_count]{};
	float gpa{};
};

Student* create_student();
void print_student(Student*);

