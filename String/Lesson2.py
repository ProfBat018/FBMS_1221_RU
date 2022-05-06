# strings - Lesson 2. String methods

# <editor-fold desc="Strip">


# text = "    test   "

# print(text.lstrip())
# print(text.rstrip())
# print(text.strip())
# </editor-fold>

# <editor-fold desc="Center">

# text = "hello"
#
# print(text.center(10 + len(text)))


# </editor-fold>

# <editor-fold desc="Endswith">

# text = "Hello"
# print(text.endswith("o"))

# </editor-fold>

# <editor-fold desc="Expandtabs">

# text = "\tqwerty"
#
# text = text.expandtabs(40)
# print(text)

# </editor-fold>

# <editor-fold desc="Find. Find and Index is the same">

# text = "Hakuna matata"

# print(text[text.find('e')])

# print(text.find('e'))
# print(text.index('e'))

# </editor-fold>

# <editor-fold desc="Format">

# Long

# a = 5
# b = 6
# txt = "{}Test{}"
# txt = txt.format(a, b)
# print(txt)

# a = 5
# b = 6
# txt = "{}Test{}".format(a, b)
# print(txt)

# a = 5
# b = 6
# txt = f"{a}Test{b}"
# print(txt)

# </editor-fold>

# <editor-fold desc="replace">

# txt = "Elvin"
# txt = txt.replace('l', '1')
# print(txt)

# </editor-fold>

# <editor-fold desc="Join">

# my_list = ['E', 'l', 'v', 'i', 'n']
#
# text = str()
#
# text = text.join(my_list)
# print(text)

# </editor-fold>

# for item in dir(text):
#     if not item.__contains__("__"):
#         print(item)

