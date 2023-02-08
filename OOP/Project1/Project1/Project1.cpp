#include <iostream>
#include <fstream>
#include "rapidjson/document.h"
#include "rapidjson/writer.h"
#include "rapidjson/stringbuffer.h"

using namespace std;
using namespace rapidjson;


class Person
{
public:
    string name;
    string surname;
    int age;

    void print()
    {
        cout << "Name is: " << name << '\n'
            << "Surname is: " << surname << '\n'
            << "Age is: " << age << '\n';
    }
};


int main()
{
    Document doc;
    fstream file("data.json", ios::in);
    string json; 
    
    while (!file.eof())
    {
        string tmp;
        file >> tmp;
        
        json += tmp;
    }

    doc.Parse(json.c_str());

	StringBuffer buffer;
	Writer<StringBuffer> writer(buffer);
	doc.Accept(writer);

    Person res;

    res.age = doc["age"].GetInt();
    res.name = doc["name"].GetString();
    res.surname = doc["surname"].GetString();
	
    res.print();


    

    return 0;
}
