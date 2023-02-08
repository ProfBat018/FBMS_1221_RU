# Условные конструкции

# <editor-fold desc="If">

# num = 7
#
# if num == 5:
#     print(5)
# if num == 6:
#     print(6)
# if num == 7:
#     print(7)
# if num == 8:
#     print(8)
# if num == 9:
#     print(9)
# else:
#     print("Error")

# </editor-fold>

# <editor-fold desc="if-else">

# num = 3
#
# if num > 5:
#     print("num > 5")
# else:
#     print("num < 5")
# if num % 2 == 0:
#     print("Even")
# else:
#     print("Odd")

# </editor-fold>

# <editor-fold desc="if-elif">

# if num > 5:
#     print("Bigger")
# elif num == 5:
#     print("Equals")
# elif num < 0:
#     print("Smaller")
# elif num == 0:
#     print("Equals to zero")

# </editor-fold>

# <editor-fold desc="Real elif">

# num = -6
#
# if num > 5:
#     print("Bigger")
# else:
#     if num == 5:
#         print("Equals")
#     else:
#         if num > 0:
#             print("Smaller")
#         else:
#             if num == 0:
#                 print("Equals to zero")

# </editor-fold>

# <editor-fold desc="and">

# num1 = 5
# num2 = 6


# if num1 == 7 or num2 == 6:
#     print("Hakuna")
# elif num1 == 5 or num2 == 6:
#     print("Matata")

# if num1 == 7 or num2 == 6:
#     print("Hakuna", end=", ")
# if num1 == 5 or num2 == 6:
#     print("Matata")

# if num1 == 7 and num2 == 6:
#     print("Hakuna")
# elif num1 == 5 and num2 == 6:
#     print("Matata")


# </editor-fold>

# age = input("Enter yes, if you adult. No if you teenager")
#
# if age == "yes":
#     print("Adult")
# if age == "no":
#     print("Teeneager")


num = 123

n1 = 123 % 10
n2 = (123 // 10) % 10
n3 = 123 // 100

new_number = n1 * 100 + n2 * 10 + n3
print(new_number)
