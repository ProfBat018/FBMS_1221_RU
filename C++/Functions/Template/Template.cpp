#include <iostream>
using namespace std;

#pragma region WithOverloading
//
//int add(int num1, int num2)
//{
//    return num1 + num2;
//}
//
//float add(float num1, float num2)
//{
//    return num1 + num2;
//}
//
//double add(double num1, double num2)
//{
//    return num1 + num2;
//}
#pragma endregion

#pragma region WithTemplate

//template <typename T>
//T add(T num1, T num2)
//{
//    return num1 + num2;
//}
//
//int main()
//{
//    auto res1 = add(1, 2);
//    cout << typeid(res1).name() << res1 << endl;
//
//    auto res2 = add(1., 2.);
//    cout << typeid(res2).name() << res2 << endl;
//
//    auto res3 = add(1.f, 2.f);
//    cout << typeid(res3).name() << res3 << endl;
//
//    auto res4 = add('a', 'b');
//    cout << typeid(res4).name() << res4 << endl;
//
//    auto res5 = add(5 > 6, 5 != 9);
//    cout << typeid(res5).name() << res5 << endl;
//
//    return 0;
//}

#pragma endregion

#pragma region Template2

//
//template <typename T1, typename T2>
//T2 add(T1 num1, T2 num2)
//{
//    return num1 + num2;
//}
//
//int main()
//{
//
//    double res = add(2, 3.);
//
//    return 0;
//}


#pragma endregion
