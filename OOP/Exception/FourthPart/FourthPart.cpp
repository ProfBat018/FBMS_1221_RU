#include <iostream>
#include "Queue.h"

using namespace std;

int main()
{
	Queue<int> myQueue{ 1, 2, 3, 4, 5 };

	try
	{
		myQueue.append(6);
	}
	catch (const std::exception& ex)
	{
		cerr << ex.what();
	}


	return 0;
}


