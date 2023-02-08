#include <iostream>
#include "BinaryTree.h"

using namespace std;



int main()
{
    auto tree = new BinaryTree {50, 25, 21, 22, 55, 53, 60};

    //tree->print(tree->getRoot());

    //cout << tree->getRoot()->value << endl;
    //cout << tree->getRoot()->left->value << endl;
    //cout << tree->getRoot()->left->left->value << endl;
    //cout << tree->getRoot()->left->left->right->value << endl;
    //cout << tree->getRoot()->right->value << endl;
    //cout << tree->getRoot()->right->left->value << endl;
    //cout << tree->getRoot()->right->right->value << endl;

    tree->print(tree->getRoot());
    tree->remove(22);

    cout << endl;
    tree->print(tree->getRoot());

    return 0;
}

