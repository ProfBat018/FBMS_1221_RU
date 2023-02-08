import random
# String - строка, str()
# Char - chr()


# <editor-fold desc="Indexes and string slices">

# text = "Elvin"
# print(text[0])
# print(text[:2])
# print(text[::2])
# print(text[::-1])

# </editor-fold>


# <editor-fold desc="String methods">

# <editor-fold desc="Concatination">

# text = "Bruce"
# surname = "Wayne"
# print(text + surname)
# text += surname
# print(text)


# </editor-fold>

# Все методы, которые начинаются на is, возвращают True or False

# text = "Batman"
# print(text.isalpha())   # Проверяет на наличие только букв. alpha - alphabet

# text = "Batman111"
# print(text.isalnum())   # alpha-numeric

# text = "🦇Batman🦇"
# print(text.isascii())   # is symbols from ASCII

# text = ' '
# print(text.isspace())

# text = "123"
# print(text.isdigit())
# print(text.isdecimal())
# print(text.isnumeric())


# text = chr(1)
# print(text.isprintable())

# text = "ELVIN"
# print(text.isupper())
# print(text.islower())

# text = "Elvin Azimov"
# print(text.istitle())

# text = "Elvin Azimov"
# text = text.upper()
# print(text)
# a = text.lower()
# print(a)

# text = "elvin"
# print(text.capitalize())

# text = "elvin azimov"
# text = text.capitalize()
# text = text.title()
# print(text)

# text = "Something.in.the .way"
#
# res = text.split('.')
# print(res)

# </editor-fold>


# text = "qwertyuiop"
#
# res = random.choice(text)
# print(res)
import string

lower_letters = string.ascii_lowercase
upper_letters = string.ascii_uppercase
symbols = string.punctuation
digits = string.digits
