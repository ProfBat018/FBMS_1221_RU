#pragma once
#include <iostream>
struct Node
{
	int value{};
	Node* left{};
	Node* right{};
	Node* parent{};

	Node(int);
};

class BinaryTree
{
public:

	void add(int);
	void edit();
	void remove(int);
	void print(Node*);
	Node* getRoot();
	Node* search(int);

	BinaryTree(int);
	BinaryTree(std::initializer_list<int>);
private:
	Node* root{};
};

