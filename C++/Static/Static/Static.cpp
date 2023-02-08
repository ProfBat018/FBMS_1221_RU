#include <iostream>
#include "FileService.h"

using namespace std;

// static variable - once initializes at start of the scope  
// static vs non-static 

void static_foo()
{
	static int a = 0;
	cout << ++a << ' ';
}
void non_static_foo()
{
	int a = 0;
	cout << ++a << ' ';
}


struct Person
{
	static int _id;

	int id = ++_id;
	char* name{};

	static void say_hello()
	{
		cout << "Hello" << endl;
	}
};

int Person::_id = 0;


int main()
{
	/*
	non_static_foo();
	non_static_foo();
	non_static_foo();
	non_static_foo();

	cout << endl;

	static_foo();
	static_foo();
	static_foo();
	static_foo();
	
	*/

	/*int a = 0;
		{
			int b = 1;
			{
				int c = 2;
				{
					int d = 3;
					{
						int e = 4;
						cout << e;
					}
					cout << d;
				}
				cout << c;
			}
			cout << b;
		}
		cout << a;*/

	
	Person* p1 = new Person();
	Person* p2 = new Person();

	cout << p1->id << endl;
	cout << p2->id << endl;

	FileService::writeToFile("data.txt", "w");

	return 0;
}
