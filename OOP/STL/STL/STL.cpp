#include <iostream>
#include <list> // + 
#include <vector> // + 
#include <set> // +
#include <map> // +
#include <forward_list> // +

using namespace std;

// STL - standart template library 

/*
	list
	vector
	set(multi, unordered)
	tuple
	map(multi, unordered)
	array
	queue
	dequeue
	stack 
	forward_list
*/

int main()
{

	//set<int> mySet{ 10, 8, 3, 6, 5, 5, 1, 3, 2, 2, 7, -5, -12 };
	//multiset<int> mySet{ 10, 8, 3, 6, 5, 5, 1, 3, 2, 2, 7, -5, -12 };

	//for(auto item : mySet)
	//{
	//	cout << item << ' ';
	//}

	//map<char, int> myMap{ {'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5} };
	


	/*forward_list<int> myForwardList{ 5, 1, 3, 4, 2, 8, 6, 7, 5 };

	for(auto item : myForwardList)
	{
		cout << item << ' ';
	}

	cout << endl;

	auto a = myForwardList.begin();

	myForwardList.emplace_after(a, 10);

	for (auto item : myForwardList)
	{
		cout << item << ' ';
	}*/

	// list - doubleLinkedList 
	// forward_list - linkedList
	return 0;
}

