# Тема урока: AJAX

## AJAX
Расшифровывается как Asynchronous JavaScript and XML.
Это технология, позволяющая обращаться к серверу без **перезагрузки страницы.**
С помощью AJAX можно отправлять и получать данные в различных форматах, например, JSON, XML, HTML и др.

Почему именно Asynchronous JavaScript and XML ?

Потому что в начале AJAX использовал XML для обмена данными,
но сейчас вместо XML чаще используют JSON.

### В каких случаях используется AJAX ?
Во всех случаях, где нам нужно сделать запрос на API и получить данные.

Например, мы хотим сделать запрос на сервер и получить список товаров.

Есть два варианта использования AJAX:
1. С помощью XMLHttpRequest
2. С помощью fetch API

Интересный факт. Вы много где в вакансиях будете видеть 
fetch API, но на самом деле это просто одна функция, которая 
под капотом использует XMLHttpRequest.

### XMLHttpRequest

XMLHttpRequest - это объект, который позволяет обмениваться данными между браузером и сервером.

Для создания объекта XMLHttpRequest используется конструктор new XMLHttpRequest().

```javascript
const xhr = new XMLHttpRequest();

// Метод open() инициализирует запрос.
// Принимает три параметра:
// 1. Метод запроса
// 2. URL запроса
// 3. Асинхронный запрос или нет

xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
```

## Fetch API

Fetch API - это новый стандарт для работы с AJAX запросами.

```javascript
fetch('https://jsonplaceholder.typicode.com/users')
  .then(response => response.json())
  .then(data => console.log(data));
```



