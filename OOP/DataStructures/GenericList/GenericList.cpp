#pragma region BoostIntro
//
//#include <iostream>
//#include <boost/any.hpp>
//
//using namespace std;
//using namespace boost;
//
//class A
//{
//public:
//	A(int value)
//	{
//		this->value = value;
//	}
//	int value;
//};
//
//class B
//{
//public:
//	B(int value)
//	{
//		this->value = value;
//	}
//	int value;
//};
//
//int main()
//{
//	any anydata = new A(5);
//
//	A* res = boost::any_cast<A*>(anydata);
//
//	cout << res->value;
//
//	anydata = new B(15);
//
//	B* res2 = boost::any_cast<B*>(anydata);
//
//	cout << res2->value;
//
//	return 0;
//}
#pragma endregion

#include <iostream>
#include <boost/variant.hpp>
#include <vector>

using namespace std;

typedef boost::variant<int, float, double, char, string, Person> anyVar;

class Person
{

};

class List
{
public:
	struct Node {
		Node* next{};
		anyVar value{};

		Node() = default;
		Node(anyVar value)
		{
			this->value = value;
		}
	};

	List() = default;

	List(initializer_list<anyVar> list)
	{
		for (auto i = list.end() - 1; i >= list.begin(); i--)
		{
			this->addToHead(*i);
		}
	}

	void addToHead(anyVar value)
	{
		Node* tmp = new Node(value);
		tmp->next = this->head;
		this->head = tmp;
	}

	Node* getHead()
	{
		return this->head;
	}
private:
	Node* head{};
}; 


ostream& operator <<(ostream& out, List& list)
{
	List::Node* current = list.getHead();

	while (current != nullptr)
	{
		out << current->value << ' ';
		current = current->next;
	}
	return out;
}


int main()
{
	Person a;
	List myList{ 1, '2', 3.2f, 4.5, string("Elvin"), 5.4, '1', 4, 2.2f, a};

	cout << myList;

	return 0;
}

