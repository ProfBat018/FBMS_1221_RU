#pragma once
#include <iostream>
#include "Tree.h"

using namespace std;

int main()
{
    auto tree = new BinaryTree{ 50, 25, 21, 22, 55, 53, 60 };


    tree->print(tree->getRoot());


	return 0;
}