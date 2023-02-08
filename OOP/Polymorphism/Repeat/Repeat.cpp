#include <iostream>
#include <string>

using namespace std;

//
//class BoardGame
//{
//public:
//	virtual void move() = 0;
//
//	BoardGame() = default;
//
//	BoardGame(int length)
//	{
//		this->length = new int(length);
//	}
//
//	~BoardGame()
//	{
//		delete length;
//	}
//
//protected:
//	int* length{};
//};
//
//
//class Monopoly : public BoardGame
//{
//public:
//	Monopoly() = default;
//	
//	Monopoly(int length) : BoardGame(length) {}
//
//	void move() override
//	{
//		cout << "Move from Monopoly to:" << ' ' << *(this->length) << ' ' << "steps" << '\n';
//	}
//};
//
//
//class Checkers : public BoardGame
//{
//public:
//	Checkers() = default;
//
//	Checkers(int length) : BoardGame(length) {}
//
//	void move() override
//	{
//		cout << "Move from Checkers to:" << ' ' << *(this->length) << ' ' << "steps" << '\n';
//	}
//};
//
// 

/*
//class Base {
//public:
//    Base() {
//        cout << "B ctor\n";
//    }
//    virtual ~Base() {
//        cout << "~B dector\n";
//    }
//    int value = 5;
//};
//
//
//class Derived : public Base {
//public:
//    Derived() {
//        cout << "D ctor\n";
//    }
//    ~Derived() {
//        cout << "~D dector\n";
//        delete name;
//    }
//    char* name = new char[6] {"Elvin" };
//};
//
*/


int main()
{
   /* Derived* derived = new Derived();

    Base* obj = derived;

    delete obj;

    cout << derived->name << endl;*/

	
    /*BoardGame* game = new Monopoly(2);

	game->move();

	game = new Checkers(1);
	
	game->move();*/


	
	return 0;
}
