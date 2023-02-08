#include <iostream>
#include "Movie.h"


const char* Movie::movieToString()
{
	switch (this->movieGenre) {
	case Drama:
		return "\nDrama\n";
	case Horror:
		return "\nHorror\n";
	case Comedy:
		return "\nComedy\n";
	case Triller:
		return "\nTriller\n";
	case Fantasy:
		return "\nFantasy\n";
	case ScienceFiction:
		return "\nScienceFiction\n";
	case Documentary:
		return "\nDocumentary\n";
	}
}


const char* Movie::toString()
{
	uint16_t name_len = strlen(this->name);
	char* name = new char[name_len + 1]{};

	name = this->name;
	name[name_len] = '\n';
	name[name_len + 1] = '\0';


	uint16_t imdb_len = 10;
	char* imdbId = new char[10]{};

	sprintf_s(imdbId, 10, "%.1f", this->imdbId);

	uint16_t genre_len = strlen(this->movieToString());
	const char* genre = this->movieToString();

	uint16_t length = name_len + imdb_len + genre_len + 3;

	char* res = new char[length] {};

	strcat_s(res, length, name);
	strcat_s(res, length, imdbId);
	strcat_s(res, length, genre);


	// char* name = new char[strlen(this->name)]{};
	//
	// char* imdbId = new char[10];
	// imdbId[10] = '\n';
	//
	// const char* genre = this->movieToString();
	//
	//
	// sprintf_s(imdbId, 10, "%f", this->imdbId);
	//
	// uint16_t length = (strlen(this->name) + strlen(imdbId) + strlen(genre));
	//
	// char* res = new char[length + 10] {};
	//
	// strcat_s(res, length + 10, name);
	// strcat_s(res, length + 10, imdbId);
	// strcat_s(res, length + 10, genre);

	return res;
}
