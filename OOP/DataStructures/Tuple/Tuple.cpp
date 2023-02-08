#include <iostream>
#include <tuple>

using namespace std;


// tuple<int, float, int, float, string> addition()
// {
// 	return tuple<int, float, int, float, string> {1, 1, 1, 1, "1"};
// }

tuple<int, int> replace(int n1, int n2)
{
	int tmp = n1;
	n1 = n2;
	n2 = tmp;

	return make_tuple(n1, n2);
}

int main()
{

	// auto elems = replace(1, 2);

	// cout << get<0>(elems);
	// cout << get<1>(elems);

	// std::pair<int, int> p(1, 2);


	// tuple<string, string, int> p1{ "Elvin", "Azimov", 20 };
	//
	// cout << get<0>(p1) << endl;
	// cout << get<1>(p1) << endl;
	// cout << get<2>(p1) << endl;

	return 0;
}
