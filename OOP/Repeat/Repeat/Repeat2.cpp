//
// Created by elvin on 10/28/2022.
//


//#include "Component.h"
//#include <iostream>
//#include <string>
//#include <utility>
//
//using namespace std;
//
//class CPU : Component {
//
//};
//
//class Printer : Component {
//
//};
//
//class Computer {
//public:
//    explicit Computer() {
//        CPU new_cpu;
//        this->processor = new_cpu;
//    }
//private:
//    Component* components{};
//    CPU processor;
//};

#include <iostream>
#include <string>

using namespace std;

class Transport {
public: // pure virtual property
    virtual void set_type(std::string) const = 0;
    virtual std::string get_type() const = 0;
protected:
    std::string type;
};

class Plane : public Transport {
public:
    std::string get_type() const override {
        return this->type;
    }
    void set_type(std::string type) const override {
        type = type;
    }
};

class Car : public Transport {

};

int main() {
//    Computer c;

    return 0;
}
