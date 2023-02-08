#pragma once

#include <iostream>
#include <string>
#include "OutOfRangeException.h"

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
			this->append(*i);
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
		if (this->capacity == 0)
		{
			throw OutOfRangeException(this->length, 1);
		}
		else
		{
			this->arr[this->length - this->capacity] = value;
			this->capacity--;
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
	T* arr{};
};

