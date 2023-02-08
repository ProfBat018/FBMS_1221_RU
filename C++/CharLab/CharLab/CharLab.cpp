#include <iostream>

using namespace std;

char* mystrchr(char* str, char s);
char* mystrstr(char* str1, char* str2);

int main()
{
	//char* name = new char[] {"ElviAzimov"};
	//char* result = mystrstr(name, new char[] {"vin"});

	char* name = new char[30]{};
	char* surname = new char[30]{};
	int a = 0;



	cin.getline(name, 30);
	cout << name << endl;

	cin >> a;
	cout << a << endl;
	cin.ignore();

	cin.getline(surname, 30);
	cout << surname << endl;

	return 0;
}

char* mystrchr(char* str, char s)
{
	int i{};

	while (*(str + i) != 0)
	{
		if (*(str + i) == s)
		{
			return (str + i);
		}
		i++;
	}
}

char* mystrstr(char* str1, char* str2)
{
	int str2_len = strlen(str2);
	int count = 0;

	for (char* i = str1, *j = str2; i < str1 + strlen(str1); i++)
	{
		if (*j == *i)
		{
			j++;
			count++;
		}
		else
		{
			j = str2;
			count = 0;
		}
		if (count == str2_len)
		{
			return i - str2_len + 1;
		}
	}
}