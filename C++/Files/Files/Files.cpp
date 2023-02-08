#include <iostream>
<<<<<<< HEAD


=======
#include  <string>
>>>>>>> 19e0df1ce3fb414e085b706784c3c12755c1f12e
void main()
{
	// File modes:
	// w - write
	// r - read
	// a - append
	// wb - write bytes
	// rb - read bytes
	// ab - append bytes

#pragma region Write
	//FILE* file{};

	// fopen_s(&file, "data.txt", "w");
	//
	// if (file)
	// {
	// 	fputs("Hello World", file);
	// }
	// if (file)
	// {
	//	 fclose(file);
	// }
#pragma endregion

#pragma region Read

	/* FILE* file;
	
	 fopen_s(&file, "data.txt", "r");
	
	 char text[100]{};
	
	 if (file)
	 {
	 	fgets(text, 100, file);
	 }
	
	 if (file)
	 {
	 	fclose(file);
	 }
	 std::cout << text;*/


#pragma endregion

#pragma region Append
	//
	// FILE* file;
	//
	// fopen_s(&file, "data.txt", "a");
	//
	// if (file)
	// {
	// 	fputs("\nBye World", file);
	// }

<<<<<<< HEAD
	/*FILE* file;

	fopen_s(&file, "data.txt", "a");

	if (file)
	{
		fputs("\nBye World", file);
	}

	if (file)
	{
		fclose(file);
	}*/
=======
	// if (file)
	// {
		// fclose(file);
	// }
>>>>>>> 19e0df1ce3fb414e085b706784c3c12755c1f12e

#pragma endregion

#pragma region ReadToEnd

	FILE* file;

	fopen_s(&file, "data.txt", "r");

	char* buffer = new char[100];

	while(fgets(buffer, 100, file))
	{
		std::cout << buffer;
	}

#pragma endregion 
}