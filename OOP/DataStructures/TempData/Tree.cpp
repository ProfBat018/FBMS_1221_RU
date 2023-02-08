#include "Tree.h"
#include <iostream>


Node::Node(int value)
{
	this->value = value;
}

BinaryTree::BinaryTree(int value)
{
	this->root = new Node(value);
}

BinaryTree::BinaryTree(std::initializer_list<int> list)
{
	for (auto i = list.begin(); i < list.end(); i++)
	{
		this->add(*i);
	}
}

void BinaryTree::add(int value)
{
	auto current = &this->root;

	if (*current == nullptr)
	{
		*current = new Node(value);
		return;
	}

	Node* parent{};

	while (*current != nullptr)
	{
		Node& node = **current;

		parent = *current;

		if (value > (*current)->value)
		{
			current = &node.right;
		}
		else if (value < (*current)->value)
		{
			current = &node.left;
		}
		else
		{
			std::cout << "This value already exists..." << std::endl;
			return;
		}
	}
	*current = new Node(value);
	(*current)->parent = parent;

}

void BinaryTree::remove(int value)
{
	auto element = this->search(value);

	if (element->right != nullptr)
	{
		element->parent->right = element->right;
		element->right->parent = element->parent;
	}
	else if(element->left != nullptr)
	{
		element->parent->right = element->left;
		element->left->parent = element->parent;
	}
	else
	{
		delete element;
		return;
	}
	delete element;
}

void BinaryTree::print(Node* element)
{
	if (element != nullptr)
	{
		std::cout << "Value is:\t" << element->value << '\t';

		if (element->parent != nullptr)
		{
			std::cout << "Parent is:\t" << element->parent->value;
		}
		else
		{
			std::cout << "Parent is:\t" << "NULL";
		}

		std::cout << std::endl;

		if (element->left != nullptr)
			this->print(element->left);
		if (element->right != nullptr)
			this->print(element->right);
	}
}


Node* BinaryTree::getRoot()
{
	return this->root;
}


Node* BinaryTree::search(int value)
{
	auto current = &this->root;

	while (*current != nullptr)
	{
		Node& node = **current;

		if (value > (*current)->value)
		{
			current = &node.right;
		}
		else if (value < (*current)->value)
		{
			current = &node.left;
		}
		else {
			return *current;
		}
	}
}



