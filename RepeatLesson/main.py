# # Процедурный
#
# class Person:
#     def __init__(self, _name, _surname, _age):
#         self.name = _name
#         self.surname = _surname
#         self.age = _age
#
#     def __str__(self):
#         return f"Name is: {self.name}\n" \
#                f"Surname is: {self.surname}\n" \
#                f"Age is: {self.age}\n"
#
#     def change_name(self, new_name):
#         self.name = new_name
#
#
# people1 = [Person("Elvin", "Azimov", 20), Person("Osman", "Zaxarna", 18)]
# people2 = [["Elvin", "Azimov", 20], ["Osman", "Zaxarna", 18]]
#
# print(people1[0])
# print(f"Name is: {people2[0][0]}\n"
#       f"Surname is: {people2[0][1]}\n"
#       f"Age is: {people2[0][2]}\n")
#


nums = [i for i in range(10)]
print(nums)
