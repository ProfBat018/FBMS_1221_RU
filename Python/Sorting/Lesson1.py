import random
import time

nums = [random.randint(1, 20) for i in range(10)]


def bubble_sort(numbers: list):
    for i in range(len(numbers)):
        count = 0
        for j in range(len(numbers) - 1):
            if nums[j] > nums[j + 1]:
                nums[j], nums[j + 1] = nums[j + 1], nums[j]
                count += 1
        if count == 0:
            break
    return numbers


def insertion_sort(numbers: list):
    for i in range(1, len(numbers)):
        key = numbers[i]

        j = i - 1

        while j >= 0 and key < numbers[j]:
            numbers[j + 1] = nums[j]
            j -= 1
        numbers[j + 1] = key

    return numbers


def selection_sort(numbers: list):
    for i in range(len(numbers)):
        index = i
        for j in range(i + 1, len(numbers)):
            if numbers[index] > numbers[j]:
                index = j

        numbers[i], numbers[index] = numbers[index], numbers[i]

    return numbers


print(nums)
nums = selection_sort(nums)
print(nums)

