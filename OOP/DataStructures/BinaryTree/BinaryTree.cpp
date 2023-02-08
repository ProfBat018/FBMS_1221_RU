#include "BinaryTree.h"

Node::Node(Value value)
{
	this->value = value;
}

BinaryTree::BinaryTree(Value value)
{
	this->root = new Node(value);
}

BinaryTree::BinaryTree(std::initializer_list<Value> list)
{
	for (auto i = list.begin(); i < list.end(); i++)
	{
		this->add(*i);
	}
}

void BinaryTree::add(Value value)
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

void BinaryTree::remove(Value value)
{
	/*auto current = &this->root;
	if (current != nullptr)
	{
		while (current != nullptr)
		{
			if ((*current)->left->value == (*current)->value)
			{

			}
		}
	}
	else
	{
		return;
	}*/
}

void BinaryTree::print(Node* element)
{
	if (element != nullptr)
	{
		std::cout << element->value << "\tParent is:\t" << element->parent->value << std::endl;

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


Node* BinaryTree::search(Value value)
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



