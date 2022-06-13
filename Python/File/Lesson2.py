# file mods - ab, rb, wb
# b - binary

# <editor-fold desc="Write and Read string">

# file = open("data2.txt", 'w')
# file.write("Hello")
# file.close()
#
# file = open("data2.txt", 'r')
# data = file.read()
# print(data)

# </editor-fold>

# <editor-fold desc="Simple write and read">

# <editor-fold desc="Write list">

# nums = list(range(1, 10))
# print(nums)
#
# file = open('data2.txt', 'w')
# file.write(str(nums))

# </editor-fold>

# <editor-fold desc="Read list">

# file = open('data2.txt', 'r')
# data = file.read()
# print(data)
# print(data[0])
# print(type(data))

# </editor-fold>

# </editor-fold>


# <editor-fold desc="Binary write and Read">

# <editor-fold desc="Write">

# import pickle
#
# nums = list(range(1, 10))
#
# file = open('data2.txt', 'wb')
# pickle.dump(nums, file)
# file.close()

# </editor-fold>


# <editor-fold desc="Read">

# import pickle
#
# file = open('data2.txt', 'rb')
#
# data = pickle.load(file)
# print(data)
# print(data[0])

# </editor-fold>

# </editor-fold>
import pickle

# class Person:
#     def __init__(self, name, surname, age):
#         self.name = name
#         self.surname = surname
#         self.age = age
#
#     def __str__(self):
#         return f"{self.name}\n" \
#                f"{self.surname}\n" \
#                f"{self.age}\n"
#
#     def say_hello(self):
#         print(f"{self.name} says hello")


# a = Person("Elvin", "Azimov", 20)
# file = open('data3.bin', 'wb')
# pickle.dump(a, file)
# file.close()


# file = open('data3.bin', 'rb')
#
# data = pickle.load(file)
#
# data.say_hello()
# print(data)
# print(type(data))
