# while - пока

# while condition:
#     action


# <editor-fold desc="While Part 1">

# while True:
#     print("Hello")


# num1 = int(input("Enter new number: "))     # 1
# num2 = int(input("Enter new number: "))     # 10
#
# i = num1
#
#
# while i < num2:
#     print(i, end=', ')
#     i += 1
#
#
# i = num1
# print()

# while i < num2:
#     if i % 2 != 0:
#         print(i, end=', ')
#     i += 1


# i = 0
# j = 0
#
# while i < 3:
#     while j < 3:
#         print(i, j)
#         j += 1
#     i += 1
#     j = 0

# </editor-fold>


# <editor-fold desc="Break&Continue">

# <editor-fold desc="Example 1">

# num = 1
# while True:
#     print("Hello")
#     if num == 5:
#         break
#     num += 1
# </editor-fold>

# <editor-fold desc="Example 2">

# result = 0
# while True:
#     num = int(input("Enter number: "))
#     if num == 0:
#         break
#     result += num
# print(result)

# </editor-fold>

# <editor-fold desc="Example 3">

# num = 5
#
# while num:
#     num -= 1
#     print("🥩")
#     if num % 2 == 0:
#         print(num)
#         continue
#     else:
#         break
# print("Finish")

# </editor-fold>

# </editor-fold>


