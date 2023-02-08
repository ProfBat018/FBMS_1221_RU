#include <iostream>
#include <string>

using namespace std;


template <typename T>
class Queue
{
public:
	Queue() = default;

	Queue(uint16_t length)
	{
		this->length = length;
		this->capacity = length;
		this->arr = new T[this->length]{};
	}

	Queue(initializer_list<T> list)
	{
		this->length = list.size();
		this->capacity = this->length;

		this->arr = new T[this->length]{};

		int j = 0;
		for (auto i = list.begin(); i < list.end(); i++, j++)
		{
			this->arr[j] = *i;
		}
	}

	T pop()
	{
		T result = this->arr[0];

		T* tmp = new T[this->length]{};

		for (size_t i = 0; i < this->length; i++)
		{
			tmp[i] = this->arr[i];
		}

		delete[] this->arr;

		this->arr = new T[this->capacity]{};
		this->length--;

		int j = 0;
		for (size_t i = 1; i < length; i++, j++)
		{
			this->arr[j] = tmp[i];
		}
		return result;
	}

	void append(T value)
	{
		if (this->length == this->capacity && this->capacity <= this->maxCapacity)
		{
			this->capacity = this->capacity + (this->capacity / 2);

			T* tmp = new T[this->length]{};

			for (size_t i = 0; i < this->length; i++)
			{
				tmp[i] = this->arr[i];
			}

			delete[] this->arr;

			this->arr = new T[this->capacity]{};
			this->length++;
			for (size_t i = 0; i < length - 1; i++)
			{
				this->arr[i] = tmp[i];
			}
			this->arr[this->length - 1] = value;
		}
		else
		{
			this->arr[this->length] = value;
			this->length++;
		}
	}

	void print()
	{
		for (size_t i = 0; i < this->length; i++)
		{
			cout << arr[i] << ' ';
		}
		cout << endl;
	}

	uint16_t get_capacity()
	{
		return this->capacity;
	}
private:
	uint16_t length{};
	uint16_t capacity{};
	const uint16_t maxCapacity = 64;
	T* arr{};
};


int main()
{

	Queue<int> myQueue{ 1, 2, 3, 4, 5 };

	myQueue.print();
	cout << "capacity is: " << myQueue.get_capacity() << endl;
	myQueue.append(6);
	myQueue.print();
	cout << "new capacity is: " << myQueue.get_capacity() << endl;
	myQueue.append(7);
	myQueue.print();
	cout << "new capacity is: " << myQueue.get_capacity() << endl;

	cout << myQueue.pop() << endl;
	myQueue.print();

	cout << myQueue.pop() << endl;
	myQueue.print();

	cout << myQueue.pop() << endl;
	myQueue.print();

	return 0;
}
