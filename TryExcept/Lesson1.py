import traceback

num1 = 5
num2 = 0

file = open("data.txt123", 'w')

try:
    file.write('1')
except:
    print("Somoething get wrong...")
finally:
    file.close()



# import requests
#
# x = requests.get("https://api.openweathermap.org/data/2.5/weather?q=baku&appid=5191fee1957155f779bfd029a4a97e18&units=metric")
#
# print(x.text)
