# Functional programming vs Procedure programming

# <editor-fold desc="Procedure">

# def find_square(radius):
#     return 3.14 * (radius ** 2)
#
#
# def find_radius(length):
#     return length / (2 * 3.14)
#
#
# l = 12
# print(find_square(find_radius(l)))


# </editor-fold>

# <editor-fold desc="Functional">

# <editor-fold desc="Reduce">

# from functools import reduce


# <editor-fold desc="Reduce with function">


# def add(num1, num2):
#     return num1 + num2
#
#
# nums = [i for i in range(10)]   # 0 1 2 3 4 5 6 7 8 9
#
#
# res = functools.reduce(add, nums)
# print(res)

# </editor-fold>

# <editor-fold desc="Reduce with lambda">
# lambda - анонимная функция

# nums = [i for i in range(10)]
# res = reduce(lambda n1, n2: n1 + n2, nums)
# print(res)

# </editor-fold>

# </editor-fold>

# <editor-fold desc="Map">

# def increment(nums):
#     res = list()
#     for num in nums:
#         res.append(num + 10)
#     return res


# <editor-fold desc="Map with function">

# def increment(num):
#     return num + 10
#
#
# nums = [i for i in range(10)]
#
# result = list(map(increment, nums))
#
# print(result)

# </editor-fold>

# <editor-fold desc="Map with lambda">

# nums = [i for i in range(10)]
#
# result = list(map(lambda x: x + 10, nums))
# print(result)

# </editor-fold>

# </editor-fold>

# <editor-fold desc="Filter">

# <editor-fold desc="With function">

# def find_even(num):
#     return num % 2 == 0
#
#
# nums = [i for i in range(10)]
#
# res = list(filter(find_even, nums))
# res2 = list(map(find_even, nums))
# print(res)
# print(res2)

# </editor-fold>

# <editor-fold desc="With lambda">


# nums = [i for i in range(10)]
#
# res = list(filter(lambda x: x % 2 == 0, nums))
# print(res)

# </editor-fold>

# </editor-fold>

# </editor-fold>

