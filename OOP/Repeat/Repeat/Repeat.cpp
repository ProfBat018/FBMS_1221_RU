#include <iostream>
#include <string>
#include <vector>

using namespace std;


class TestBank
{
public:
	vector<Category*> banks{};
};


class Category
{
public:
	Category(string name, int testCount)
	{
		this->name = name;
		this->testCount = testCount;
	}
	string name{};
	int testCount{};
	vector<Test> tests{};
};

class Test
{
	string name;
	int questionsCount{};
};

int main()
{
	TestBank a;
	a.banks.push_back(new Category("English", 3));

	return 0;
}
