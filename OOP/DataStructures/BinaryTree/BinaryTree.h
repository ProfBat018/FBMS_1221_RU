#pragma once
#include <iostream>
#include "boost/variant/variant.hpp";

// Создал свой тип данных под названием Value, который может быть одним из <int, float, double, char, long long>
typedef boost::variant<int, float, double, char, long long> Value;


struct Node
{
	Value value{};
	Node* left{};
	Node* right{};
	Node* parent{};

	Node(Value);
};

class BinaryTree
{
public:

	void add(Value);
	void edit();
	void remove(Value);
	void print(Node*);
	Node* getRoot();
	Node* search(Value);

	BinaryTree(Value);
	BinaryTree(std::initializer_list<Value>);
private:
	Node* root{};
};
