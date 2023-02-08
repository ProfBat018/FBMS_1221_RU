#include <iostream>
#include <set>
#include <vector>

using namespace std;



int main()
{
	set<int> mySet;

	mySet.insert(7);
	mySet.insert(5);
	mySet.insert(3);
	mySet.insert(1);
	mySet.insert(0);

	for (int i: mySet)
	{
		cout << i << endl;
	}
}
