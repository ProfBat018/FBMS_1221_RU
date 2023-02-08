# nums = [1, 2, 3, 4, 5]

# <editor-fold desc="Вывод списка на экран">

# print(nums)
# print(nums[0])
# print(nums[1])
# print(nums[2])
# print(nums[3])
# print(nums[4])

# </editor-fold>

# <editor-fold desc="Вывод списка через цикл For">

# for i in range(5):
#     print(nums[i])

# for i in range(len(nums)):
#     print(nums[i])

# </editor-fold>

# <editor-fold desc="Вывод списка через цикл foreach">

# for i in nums:
#     print(i)

# </editor-fold>

# <editor-fold desc="Методы списков">

# <editor-fold desc="Append-добавляет в конец">

# nums.append(10)
# print(nums)

# </editor-fold>

# <editor-fold desc="Pop-удаляет с конца, или удаляет по индексу">

# nums.pop()
# print(nums)

# nums.pop(2)
# print(nums)

# </editor-fold>

# <editor-fold desc="Copy-выполняет глубокое копирование">

# a = nums.copy()
# print(a)
# nums.pop()
# print(a)

# </editor-fold>

# <editor-fold desc="Count-считает количество определенных элементов в списке">

# nums.append(1)
# nums.append(1)
# nums.append(1)
#
# print(nums.count(1))

# </editor-fold>

# <editor-fold desc="Extend-расширяет наш список другим списком">

# nums2 = [6, 7, 8, 9, 10]
# print(nums)
# nums.extend(nums2)
# print(nums)

# </editor-fold>

# <editor-fold desc="Reverse-переворачивает список">

# print(nums)
# nums.reverse()
# print(nums)

# </editor-fold>

# <editor-fold desc="Remove-убирает элемент по значению">

# nums.append(1)
# nums.append(1)
# nums.append(1)
#
# print(nums)
#
# for i in range(nums.count(1)):
#     nums.remove(1)
#
# print(nums)

# nums.remove(1)
# print(nums)
#
# nums.remove(1)
# print(nums)
#
# nums.remove(1)
# print(nums)
#
# nums.remove(1)
# print(nums)

# </editor-fold>

# <editor-fold desc="Index-показывает первое вхождение элемента">

# nums.append(5)
# nums.append(5)
# nums.append(5)

# print(nums.index(5))
# print(nums.index(5))
# print(nums.index(5))

# for i in range(len(nums)):
#     if nums[i] == 5:
#         print(i)

# </editor-fold>

# <editor-fold desc="Insert-Вставляет элемент по определенному индексу">

# print(nums)
# nums.insert(1, 5)   # Добавь 5 на 0 индекс
# print(nums)

# </editor-fold>

# <editor-fold desc="Sort-сортирует список">

# nums.sort()
# print(nums)

# </editor-fold>

# <editor-fold desc="Clear-очищает список">

# print(nums)
# nums.clear()
# print(nums)

# </editor-fold>

# </editor-fold>

#  Создайте список. Добавьте туда все элементы от 0 до 100 по возрастанию

# <editor-fold desc="Example 1">

# start = 0
# end = 100
# nums = []
#
# for i in range(start, end + 1):
#     nums.append(i)
#
# print(nums)
# </editor-fold>

# <editor-fold desc="Example 2">

# nums = [i for i in range(101)]
# print(nums)

# </editor-fold>

# <editor-fold desc="Example 3">
# cars = ["Mercedes", "BMW", "Lexus", "Ford", "Chevrolet", "Geely"]
# print(cars[1][0])
# print(cars[-1][0])
# print(cars[-1][-1])

# </editor-fold>

# <editor-fold desc="Example 4">

# cars = [["Mercedes", "CLS 350", 2020, True], ["Tesla", "Model S Plaid", 2022, True]]

# print(cars)
# print(cars[0])
# print(cars[0][0])
# print(cars[0][0][0])
# print(cars[0][2][0])

# </editor-fold>

# Пользователь вводит N чисел. Найти сумму всех этих чисел.

# <editor-fold desc="Example 1">

# nums = list()
# count = int(input("Enter count of numbers: "))
#
# for i in range(count):
#     nums.append(int(input("Enter new number: ")))
#
# print(nums)

# </editor-fold>

# <editor-fold desc="Example 2">

# nums = list()
# count = int(input("Enter count of numbers: "))
#
# addition = 0
#
# for i in range(count):
#     number = int(input(f"Enter {i + 1} number: "))
#     nums.append(number)
#
# print(nums)
# for i in range(count):
#     addition += nums[i]
#
# print(addition)

# </editor-fold>


"""numb1 = int(input("Введите первое число: "))
numb2 = int(input("Введите второе число: "))
numb3 = int(input("Введите третье число: "))
otvet=(numb1*100+numb2*10+numb3)
print(otvet)"""



number = input('Введите число: ')
count = 1
for i in number:
    count *= int(i)
print(count)

#Учитель for мы прошли поэтому так легкче было
"""Metr = int(input("Введите количество метров"))
print(f'{Metr} метров = {Metr*1000} миллиметров')
print(f'{Metr} метров = {Metr*100} сантиметров')
print(f'{Metr} метров = {Metr*10} дециметров')
print(f'{Metr} метров = {Metr/1609} миль')"""


