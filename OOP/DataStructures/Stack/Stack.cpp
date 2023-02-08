#include <iostream>

template <typename T>
class Stack
{
public:
	Stack() = default;
	Stack(uint16_t length)
	{
		this->length = length;
	}
	Stack(std::initializer_list<T> list)
	{
		this->length = list.size();
		this->arr = new T[this->length]{};

		int j = 0;
		for (auto i = list.begin(); i < list.end(); ++i, ++j)
		{
			arr[j] = *i;
		}
	}

	uint16_t get_len()
	{
		return  this->length;
	}
	void print_stack()
	{
		for (int i = 0; i < this->length; ++i)
		{
			std::cout << arr[i] << ' ';
		}
		std::cout << std::endl;
	}
	T pop()
	{
		if (this->length >= 1)
		{

			uint16_t new_length = this->length - 1;

			T result = this->arr[new_length];

			T* tmp = new T[new_length];

			for (int i = 0; i < new_length; ++i)
			{
				tmp[i] = this->arr[i];
			}

			delete[]this->arr;

			this->arr = new int[new_length] {};

			for (int i = 0; i < new_length; ++i)
			{
				this->arr[i] = tmp[i];
			}

			delete[] tmp;
			this->length = new_length;

			return result;
		}
		return  0;
	}
private:
	uint16_t length{ 5 };
	T* arr = new T[length]{};
};



int main()
{
	Stack<int> my_stack{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	my_stack.print_stack();


	std::cout << my_stack.pop() << std::endl;
	std::cout << my_stack.get_len() << std::endl;

	my_stack.print_stack();

	return EXIT_SUCCESS;
}
