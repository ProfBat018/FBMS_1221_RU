# Тема урока: Jquery

## Jquery - это библиотека JavaScript, 
которая упрощает работу с DOM-деревом,
анимацией,
AJAX и другими вещами,
которые делают JavaScript таким популярным.

Также Jquery состоит из набора функций, 
которые позволяют упростить работу с JavaScript, 
а именно с анимациями, переходами, и созданием
новый элементов на странице.


## Подключение Jquery
* CDN Ссылка
* Скачивание с официального сайта
* NPM

## Синтаксис Jquery

```js

// По сути selector jquery - это document.querySelectorAll

let body  = $('body');
let btn = $('button');

body.append(`<h1>Привет, мир!</h1>`);


let h1 = $('h1');

h1.css({ color: 'red', fontSize: '50px' });


let isShow = true;
btn.on('click', function()  {
    // give transition
    h1.css({ transition: 'all 1s' });
    // change color
    h1.css({ color: 'blue' });

    if (isShow) {
        h1.hide()
        isShow = false;
    } else {
        h1.show()
        isShow = true;
    }
});



```

## Почему Jquery устарел ?
* Появился React, Vue, Angular
* Короче говоря все что не SPA, PWA - устарело(для крупных проектов)

## Как сделать AJAX запрос с помощью Jquery

```js

$.ajax({
    url: 'https://jsonplaceholder.typicode.com/posts',
    method: 'GET',
    success: function(data) {
        console.log(data);
    },
    error: function(err) {
        console.log(err);
    }
});

```
и это по факту мое самое любимое в Jquery, так как очень удобно делать запросы на сервер

## Пример анимации с помощью Jquery

```js

let btn = $('button');

btn.on('click', function() {
    $('h1').animate({
        opacity: 0.25,
        left: "+=50",
        height: "toggle"
    }, 5000, function() {
        // Animation complete.
    });
});

```


