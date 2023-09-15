# Тема урока: DOM 

## DOM - Document Object Model

По сути мы уже с вами знаем, что JS код интерпретируется 
браузером и выполняется в нем.
Но как же он взаимодействует с HTML и CSS?
Для этого существует такая штука как DOM.
DOM - это объектная модель документа,
которая представляет собой древовидную структуру HTML документа.

## DOM API

DOM API - это набор методов и свойств, которые позволяют
взаимодействовать с DOM.

## DOM API - document

Объект document - это корневой объект DOM.

Есть несколько способов обратится к `html` элементу:
1. `document.documentElement` - возвращает `html` элемент
2. `document.getElementById('#id')` - возвращает элемент по `id`
3. `document.getElementsByClassName('.class')` - возвращает элемент по `class`
4. `document.getElementsByTagName('tag')` - возвращает элемент по тегу
5. `document.querySelector('css-selector')` - возвращает элемент по css селектору
6. `document.querySelectorAll('css-selector')` - возвращает все элементы по css селектору
7. `document.getElementsByName('name')` - возвращает элементы по атрибуту `name`





