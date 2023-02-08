#include <iostream>
#include <vector>
#include <list>

using namespace std;

struct Person
{
    string name;
    string surname;
    int age;
};

struct Employee : Person
{
    uint16_t salary;
    uint16_t expreience;
};

struct Teacher : Employee
{
    uint16_t groupCount;
};

struct Curator : Employee
{
    uint16_t groupCount;
    uint16_t teacherCount;
};


int main()
{
    std::vector<Employee*> workers {new Teacher(), new Curator()};


    return 0;
}
