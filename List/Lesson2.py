# Сформировать третий список, содержащий элементы
# обоих списков

# <editor-fold desc="Task 1">


# import random
#
# nums1 = list()
# nums2 = list()
# nums3 = list()
#
# length = int(input("Enter length of list: "))
# start = int(input("Enter start of random: "))
# end = int(input("Enter end of random: "))
#
# for i in range(length):
#     nums1.append(random.randint(start, end))
#     nums2.append(random.randint(start, end))
#
# nums3.extend(nums1)
# nums3.extend(nums2)
#
# print(nums1)
# print(nums2)
# print(nums3)

# </editor-fold>

# Сформировать третий список, содержащий элементы
# обоих списков без повторений;

# <editor-fold desc="Task 2">

# import random
#
# nums1 = list()
# nums2 = list()
# nums3 = list()
#
# length = int(input("Enter length of list: "))
# start = int(input("Enter start of random: "))
# end = int(input("Enter end of random: "))
#
# for i in range(length):
#     nums1.append(random.randint(start, end))
#     nums2.append(random.randint(start, end))
#
#
# nums3.extend(nums1)
# nums3.extend(nums2)
#
#
# for i in nums3:
#     for j in range(nums3.count(i) - 1):
#         nums3.remove(i)

# </editor-fold>

# Сформировать третий список, содержащий элементы
# общие для двух списков;

# <editor-fold desc="Task 3">

# import random
#
# nums1 = list()
# nums2 = list()
# nums3 = list()
#
# length = int(input("Enter length of list: "))
# start = int(input("Enter start of random: "))
# end = int(input("Enter end of random: "))
#
#
# for i in range(length):
#     nums1.append(random.randint(start, end))
#     nums2.append(random.randint(start, end))

# <editor-fold desc="For">

# for i in range(len(nums1)):
#     for j in range(len(nums2)):
#         if nums1[i] == nums2[j] and nums3.count(nums1[i]) == 0:
#             nums3.append(nums1[i])
#             break
#

# </editor-fold>

# <editor-fold desc="While">

# i = 0
# j = 0
#
# while i < length:
#     while j < length:
#         if nums1[i] == nums2[j] and nums3.count(nums1[i]) == 0:
#             nums3.append(nums1[i])
#             break
#         else:
#             j += 1
#     j = 0
#     i += 1
# print(nums3)

# </editor-fold>

# <editor-fold desc="For 2">

# check = True
# for i in range(len(nums1)):
#     for j in range(len(nums2)):
#         if nums1[i] == nums2[j]:
#             for k in range(len(nums3)):
#                 if nums1[i] == nums3[k]:
#                     check = False
#                     break
#                 else:
#                     check = True
#             if check:
#                 nums3.append(nums1[i])
#                 check = False
#                 break
#
# print(nums3)

# </editor-fold>

# <editor-fold desc="Cheater theme">

# for i in range(length):
#     if nums1[i] in nums2 and nums1[i] not in nums3:
#         nums3.append(nums1[i])
#
# print(nums3)
# </editor-fold>

# </editor-fold>




import random

nums = list()

length = int(input("Enter length of list: "))
start = int(input("Enter start of random: "))
end = int(input("Enter end of random: "))

for i in range(length):
    nums.append(random.randint(start, end))

minimum = nums[0]
maximum = nums[0]

for i in range(length - 1):
    if maximum < nums[i + 1]:
        maximum = nums[i + 1]

    if minimum > nums[i + 1]:
        minimum = nums[i + 1]


print(nums)
print(maximum)
print(minimum)

