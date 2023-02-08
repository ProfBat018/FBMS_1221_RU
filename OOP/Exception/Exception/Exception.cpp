#include <iostream>

using namespace std;

class ArithmeticException : public std::exception
{
public:
	ArithmeticException(const char* message) : std::exception(message)
	{
		this->message = message;
	}

	char const* what() const override
	{
		return this->message;
	}

	const char* message = new char[1024] {};
};


float divide(float n1, float n2)
{
	if (n2 != 0)
	{
		return n1 / n2;
	}
	throw ArithmeticException("error");
}


int main()
{
	int a = 5, b = 0;

	try
	{
		cout << divide(5, 0);
	}
	catch (const std::exception& error)
	{
		cout << error.what() << endl;
	}

	
	cout << "End of main" << endl;

	return 0;
}
