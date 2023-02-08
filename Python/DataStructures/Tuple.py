# cars = [["Mercedes", "CLS 350", 2021], ["BMW", "M5", 2021]]

# def foo():
#     a = 5
#     b = 6
#     return a, b
#
#
# res = foo()
#
# res = list(res)
#
# print(res)


def addition(*nums, num1, num2):    # * - endless arguments
    total = 0

    for number in nums:
        total += number

    return total


print(addition(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, num1=1, num2=2))


