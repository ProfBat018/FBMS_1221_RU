#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

// Procedural programming - using functions to create procedures and access, work with data
// OOP - Object oriented programming, creating objects with structs and classes.

// Functional programming 

#pragma region Part1
//
//vector<int> showEven(vector<int> nums)
//{
//	vector<int> res{};
//
//	for (auto i : nums)
//	{
//		if (i % 2 == 0)
//		{
//			res.push_back(i);
//		}
//	}
//
//	return res;
//}
//
//
//bool isEven(int num)
//{
//	return num % 2 == 0;
//}

//template<typename T>
//T myFindIf(T begin, T end, bool (*predicate) (int))
//{
//	for (auto i = begin; i < end; i++)
//	{
//		if (predicate(*i))
//		{
//			return i;
//		}
//	}
//	throw;
//}

//int main()
//{
	//vector<int> nums{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	//auto it = find_if(nums.begin(), nums.end(), isEven);

	//auto res = myFindIf(nums.begin(), nums.end(), isEven);

	//cout << *res;

	/*vector<int> evenNums = showEven(nums);

	for (auto i : evenNums)
	{
		cout << i << ' ';
	}*/

	//return 0;
//}

#pragma endregion


#pragma region Part2

int main()
{
	vector<int> nums{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	auto i = for_each(nums.begin(), nums.end(), [](int num)
		{
			if (num % 2 == 0)
			{
				cout << num << ' ';
			}
		});


	//auto i = find_if(nums.begin(), nums.end(), [](int num)
	//	{
	//		return num % 2 == 0;
	//	});


	return 0;
}
#pragma endregion
