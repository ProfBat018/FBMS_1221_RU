#include <iostream>
#include <map>

using namespace std;

template <typename T> 
std::pair<T, T> foo()
{
	return pair<T, T>(1, 2);
}

int main()
{
	//std::pair<char, int> ascii_pair{};

	//ascii_pair.first = 'a';
	//ascii_pair.second = 97;

	//cout << ascii_pair.first << ' ' << ascii_pair.second << endl;

	/*
	auto a = foo<int>();
	cout << a.first << ' ' << a.second << endl;
	*/

	std::map<string, int> b;

	b.insert(pair<string, int>("elvin", 21));
}

