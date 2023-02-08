#include <iostream>

using namespace std;

template <typename T>
class SmartPtr {
public:
	explicit SmartPtr(T* ptr)
	{
		this->ptr = ptr;
	}

	~SmartPtr() { delete (ptr); }

	T& operator*() { return *ptr; }
	T* operator&() { return ptr; }

	SmartPtr& operator=(SmartPtr& other)
	{
		SmartPtr res(new T(*other));
		return res;
	}

	void operator+(int value) { this->ptr += value; }

private:
	T* ptr{};
};




int main()
{
#pragma region Part1

	/*

	SmartPtr<int> a(new int(10));

	SmartPtr<int> b = a;

	cout << "A is: " << *a << endl;
	cout << "B is: " << *b << endl;

	*/


	/*
		unique_ptr<T>
		shared_ptr<T>
		weak_ptr<T>
	*/

#pragma endregion

#pragma region Part2

	/*
	SmartPtr<int> ptr1(new int(1));
	{
		SmartPtr<int> ptr2(new int(2));
		{
			SmartPtr<int> ptr3(new int(3));
			{
				SmartPtr<int> ptr4(new int(4));
			}
		}
	}
	*/

#pragma endregion

#pragma region uniqie_ptr

	/*
	unique_ptr<int> ptr1(new int(1));
	unique_ptr<int> ptr2(new int(2));

	cout << ptr1 << ' ' << *ptr1 << endl;
	cout << ptr2 << ' ' << *ptr2 << endl;
	*/


	// Unique ptr methods

	/*
		int* res = ptr1.get();
		cout << *res;
	*/
	/*
		ptr1.reset();
		cout << ptr1 << ' ' << *ptr1 << endl;
	*/
	/*
		int* a = ptr1.release();
		cout << *a << endl;
	*/
	/*
		ptr1.swap(ptr2);

		cout << ptr1 << ' ' << *ptr1 << endl;
		cout << ptr2 << ' ' << *ptr2 << endl;
	*/

#pragma endregion

#pragma region shared_ptr
	// shared_ptr<int> ptr1(new int(1));
	// shared_ptr<int> ptr2(new int(2));

	/*
		cout << ptr1 << ' ' << *ptr1 << endl;
		cout << ptr2 << ' ' << *ptr2 << endl;

		ptr2 = ptr1;

		cout << ptr1 << ' ' << *ptr1 << endl;
		cout << ptr2 << ' ' << *ptr2 << endl;

	*/

	// shared_ptr Functions 

	/*
		cout << ptr1.owner_before(ptr2);
	*/


#pragma endregion


#pragma region weak_ptr

	//shared_ptr<int> ptr1(new int(1));
	//shared_ptr<int> ptr2(new int(2));

	//weak_ptr<int> weak_ptr1(ptr1);
	//weak_ptr<int> weak_ptr2(ptr1);

	// weak_ptr methods

	/*
		ptr1.~shared_ptr();
		cout << weak_ptr1.expired();
	*/

	/*


	*/

	//if (!weak_ptr1.expired())
	//{
	//	shared_ptr<int> ptr3(weak_ptr1);
	//	cout << ptr3 << ' ' << *ptr3 << endl;
	//}


	const int* a = new int(5);

	int* b = const_cast<int*>(a);

	*b = 10;

	cout << *a;
	


#pragma endregion

	return 0;
}
