nums = [8, 38, 3, 14, 34, 4, 23, 29, 23, 27]


def bubble_sort(numbers: list):
    for i in range(len(numbers)):
        for j in range(len(numbers) - 1):
            if nums[j] > nums[j + 1]:
                tmp = nums[j]
                nums[j] = nums[j + 1]
                nums[j + 1] = tmp
    return numbers


print(nums)
nums = bubble_sort(nums)
print(nums)

