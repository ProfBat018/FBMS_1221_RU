#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;


int main()
{
#pragma region Part1

	//  Структура - должна описывать простой тип.
	//  Класс - может описывать все что угодно. 

	// так как стуктура маленькая, то ее можно хранить в  stack
	// так как класс скорее всего большой, то его надо хранить в heap

	// capacity = capacity + capacity / 2
	// capacity by default = 32

	////vector<int> *arr = new vector<int>;
	// Приходится писать тип и слева и справа.

	//vector<int> arr{1, 2, 3, 4, 5};

	//cout << arr->begin();

	//for (int item : arr) {
	//	cout << item;
	//}
#pragma endregion

#pragma region Part2

	//vector<int> arr{ 1, 2, 3, 4, 5 };

	//cout << arr.capacity() << endl;

	//arr.push_back(6); // append

	//cout << arr.capacity() << endl;

	//arr.push_back(7); 
	//arr.push_back(8); 

	//cout << arr.capacity() << endl;

	//arr.insert(arr.begin() + 5, 10);

	//arr.insert(arr.begin() + 2, 10, 9);

	//for (int i : arr) {
	//	cout << i << ' ';
	//}
	//cout << endl;

	//sort(arr.begin(), arr.end());

	//for (int i : arr) {
	//	cout << i << ' ';
	//}

#pragma endregion

#pragma region Part3
	//vector<int> a {1, 2, 3, 4, 5, 6};

	//vector<int> arr(a.begin(), a.begin() + 4);
	//vector<int> arr(10);

	//for (int i : arr) {
	//	cout << i;
	//}

#pragma endregion

#pragma region Part4

#pragma endregion
	return 0;
}
