# <editor-fold desc="Input">
# num1 = input()  # По умолчанию input возвращает string
# num2 = input()
# print(num1 + num2)
#
# num3 = "1"
# num4 = "2"
# print(num3 + num4)
# </editor-fold>

# <editor-fold desc="Input and print(f'')">

# first_number = int(input("Enter fisrt number: "))
# second_number = int(input("Enter second number: "))
#
# result = first_number + second_number
#
# print(first_number, '+', second_number, '=', result)
#
# print(f"{first_number} + {second_number} = {result}")  # string interpolation
#
# print("{} + {} = {}" .format(first_number, second_number, result))

# </editor-fold>

# <editor-fold desc="Interpolation vs Concatenation">

# <editor-fold desc="Concatenation">

# first_name = "Elvin"
# last_name = "Azimov"
#
# print(first_name + last_name)

# </editor-fold>

# <editor-fold desc="Interpolation">

# first_name = "Elvin"
# second_name = "Azimov"
#
# result = f"{first_name}🐱‍👤{second_name}"
#
# print(result)

# </editor-fold>


# </editor-fold>

# <editor-fold desc="Arithmetical operators">

# first_num = int(input("Enter first number: "))
# second_num = int(input("Enter second number: "))
#
# print(f"{first_num} + {second_num} = {first_num + second_num}")
# print(f"{first_num} - {second_num} = {first_num - second_num}")
# print(f"{first_num} * {second_num} = {first_num * second_num}")
# print(f"{first_num} / {second_num} = {first_num / second_num}")
# print(f"{first_num} % {second_num} = {first_num % second_num}")
# print(f"{first_num} // {second_num} = {first_num // second_num}")
# print(f"{first_num} ** {second_num} = {first_num ** second_num}")

# </editor-fold>

# <editor-fold desc="Logical operators">

# first_num = 5
# second_num = 6
#
# print(first_num > second_num)
# print(first_num == second_num)
# print(first_num != second_num)

# </editor-fold>

# <editor-fold desc="Sep&And">

# print(*args, **kwargs)  endless arguments, endless keywords arguments

# print(1, 2, 3, 4, 5, sep='$')   # sep - separate(отделять)
# print("Elvin")

# print(1, 2, 3, 4, 5, sep='$', end='-')   # sep - separate(отделять) end - endline
# print("Elvin")

# print(1, 2, 3, 4, 5, sep=' ', end='\n')   # sep - separate(отделять) end - endline
# print("Elvin")

# </editor-fold>

num = 26

num2 = num % 10
num3 = num // 10

print(num3)
print(num2)
