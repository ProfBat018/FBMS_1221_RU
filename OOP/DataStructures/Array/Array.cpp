#include <iostream>

class MyArray
{
public:
	int* begin()
	{
		return this->arr;
	}

	int* end()
	{
		return &(this->arr[10]);
	}
private:
	int* arr = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
};

int main()
{
	MyArray array;

	for(auto i: array) // foreach
	{
		std::cout << i;
	}

	for (int* i = array.begin(); i < array.end(); ++i)
	{
		std::cout << *i;
	}

	return 0;
}

