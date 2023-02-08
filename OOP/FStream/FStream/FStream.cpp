#include <iostream>
#include <string>
#include <fstream>
#include <sstream>

using namespace std;

//fstream  -  output and input 
//ofstream -  output
//ifstream -  input


int main()
{

	/*
	string a = "5";
	int num;
	stringstream stream;

	stream << a;
	stream >> num;

	cout << num;
	*/


	int num = 5;

	string res = to_string(num);



	/*
	
	ofstream file("data2.txt");

	file << "Hello";*/

	//ifstream file("data2.txt");
	//string result;

	//while (getline(file, result))
	//{
	//	cout << result << endl;
	//}


	//std::fstream write_file("data.txt", std::ios::out);
	//write_file << "Hello World\nByeWorld";

	/*std::fstream read_file("data.txt", std::ios::in);
	
	std::string buffer;

	while (std::getline(read_file, buffer))
	{
		std::cout << buffer << std::endl;
	}*/


	//fstream file("data2.txt", ios::app);
	//file << "\nMaga molodec";
	

	//string name = "Elvin Azimov";

	//name.find('+');

	return 0;
}