#pragma once

struct Movie
{
	enum GENRE { Drama, Horror, Comedy, Triller, Fantasy, ScienceFiction, Documentary };

	char* name{};
	float imdbId{};
	GENRE movieGenre{};

	const char* toString();
	const char* movieToString();
};
