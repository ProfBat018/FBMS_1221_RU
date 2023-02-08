#include <iostream>

struct Student
{
	uint16_t id{};
	char* name{};
};




int main()
{

#pragma region Writing_to_file

	// Student* students = new Student[3];

	// students[0] = *(new Student{ 1, new char[5] {"Maga"} });
	// students[1] = *(new Student{ 2, new char[6] {"Leman"} });
	// students[2] = *(new Student{ 3, new char[5] {"Lala"} });

	// FILE* file;

	// fopen_s(&file, "data.txt", "a");

	// char* id = new char[5] {};
	// _itoa_s(students[1].id, id, 10, 10);


	// fputs(id, file);
	// fputs(" ", file);
	// fputs(students[1].name, file);
	// fputs("\n", file);


#pragma endregion

#pragma regiion ReadFromFile

	int student_count = 2;
	char** res = new char* [student_count] {}; 

	for (int i = 0; i < student_count; ++i)
	{
		res[i] = new char[30] {};
	}

	FILE* file{};
	fopen_s(&file, "data.txt", "r");

	if (file)
	{
		int i = 0;
		while (fgets(res[i], 100, file))
		{
			i++;
		}
	}

	if (file)
	{
		fclose(file);
	}


	// for (int i = 0; i < student_count; ++i)
	// {
	// 	std::cout << res[i];
	// }


	Student* tmp = new Student[2];

	
	for (int i = 0, cursor = 0; i < student_count; ++i)
	{
		char* id = new char[5] {};
		char* name = new char[30] {};

		int j = 0;
		cursor = 0;
		while (res[i][j] != ' ')
		{
			id[cursor] = res[i][j];
			++cursor;
			++j;
		}

		++j;

		cursor = 0;
		while (res[i][j] != '\n')
		{
			name[cursor] = res[i][j];
			++cursor;
			++j;
		}
		tmp[i].id = atoi(id);
		tmp[i].name = name;
	}

	std::cout
		<< tmp[0].id << ' ' << tmp[0].name << std::endl
		<< tmp[1].id << ' ' << tmp[1].name << std::endl;

#pragma endregion

	return 0;
}
