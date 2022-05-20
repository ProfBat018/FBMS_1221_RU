# set - множество
# объединение, пересечение и т.д.

nums1 = {1, 2, 3, 4}
nums2 = {3, 4, 5, 6}

# <editor-fold desc="UNION">

# nums1 = nums1.union(nums2)
# print(nums1)

# </editor-fold>

# <editor-fold desc="Intersection - Пересечение">

# print(nums1.intersection(nums2))

# </editor-fold>

# <editor-fold desc="difference">

# print(nums1.difference(nums2))
# print(nums2.difference(nums1))
# print(nums1.symmetric_difference(nums2))

# </editor-fold>

# <editor-fold desc="Update Methods">

# res = nums1.intersection(nums2)
#
# nums1.intersection_update(nums2)
# print(nums1)

# </editor-fold>

# <editor-fold desc="SubSet & SuperSet">

# a = {1, 2}
# b = {1, 2, 3, 4}
#
# print(a.issubset(b))
# print(b.issuperset(a))
#
# print(b.issubset(a))
# print(a.issuperset(b))

# </editor-fold>


# nums1.discard(8)
# print(nums1)
# nums1.remove(8)
# print(nums1)
