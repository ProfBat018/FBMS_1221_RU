# Тема урока: Асинхронный JavaScript

Вы уже знаете что такое асинхронность. Но теперь нам надо погвоорить 
о том, как `JavaScript` работает.

`JavaScript` - это однопоточный язык программирования. Это значит, что
все операции выполняются последовательно. Но это не значит, что `JavaScript`
не может выполнять несколько операций одновременно. Вы можете спросить,
почему `Js` это однопоточный язык. Это потому что `JavaScript` работает
в браузере, а браузер - это однопоточное приложение. Мы не можем попросить
браузера выделить нам поток. У нас просто нет доступа к потокам. Но мы можем
попросить браузер выполнить некоторые операции асинхронно. То есть если подумать,
операции которые мы выполняем на `Frontend` - это операции ввода/вывода и они 
не занимают так много процессорного времени.

Сразу есть несколько вопросов, которые я задал сам себе когда учился: 
1. Как тогда реализовать многопоточность в `Node.js` ?
2. Какие способы асинхронности есть в `JavaScript` ?
3. Какие есть проблемы с асинхронностью в `JavaScript` ?

Давайте по порядку.

## Многопоточность в Node.js

`Node.js` - это среда выполнения `JavaScript` на сервере. И `Node.js`
построен на `V8` - движке `JavaScript` от `Google`. И `V8` - это однопоточный
движок. То есть `Node.js` - это однопоточный сервер. Но тогда как же `Node.js`
реализует многопоточность ? Ответ простой: `Node.js` использует многопоточность
операционной системы. То есть `Node.js` использует потоки операционной системы.

Как так получается что `Node.js` использует потоки операционной системы, а `JavaScript`
не может использовать потоки ? Ответ простой: `Node.js` может использовать потоки
`OS`, потому что `Node.js` - это не `JavaScript`. `Node.js` - это `JavaScript` + `C++`.

То есть по факту `V8` взяли и вытащили из `Chrome` и сделали из него отдельный
интерпретатор с `API` для `C++`. Подробности будут в будущем.

## [Важно прочитать](https://habr.com/ru/companies/wrike/articles/302896/)

## Способы асинхронности в JavaScript
1. Callbacks
2. Promises
3. Async/Await
4. Generators


## Callbacks

Я думаю из названия можно понять, что `Callback` - это функция, которая
будет вызвана после того как другая функция завершит свое выполнение.

```js
function doSomething(callback) {
    setTimeout(() => {
        console.log('doSomething');
        callback();
    }, 1000);
}

function doSomethingElse() {
    console.log('doSomethingElse');
}

doSomething(doSomethingElse);
```

В примере выше мы вызываем функцию `doSomething` и передаем ей в качестве
аргумента функцию `doSomethingElse`. Функция `doSomething` вызывает функцию
`setTimeout` и передает ей в качестве аргумента функцию, которая будет вызвана
после того как `setTimeout` завершит свое выполнение. То есть функция `doSomething`
выполняет асинхронную операцию. А функция `doSomethingElse` - это `Callback`.


## Promises

По сути и в `C++` и в `Java` есть такое понятие, в `C#` они называются `Task`.
Мы даем обещание, что выполним какую-то операцию и когда она завершится, мы
вызовем функцию, которую вы передали нам в качестве аргумента.

```js
function doSomething() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('doSomething');
            resolve();
        }, 1000);
    });
}

function doSomethingElse() {
    console.log('doSomethingElse');
}

doSomething().then(doSomethingElse);
```

## Async/Await

В `Js` он появился недавно, и при этом нам надо понимать что такая конструкция
невозможна в однопоточном языке. И поэтому это всего лишь `Syntactic Sugar` над `Promises`.

```js
async function doSomething() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('doSomething');
            resolve();
        }, 1000);
    });
}

function doSomethingElse() {
    console.log('doSomethingElse');
}

async function doSomethingElseAsync() {
    await doSomething();
    doSomethingElse();
}

doSomethingElseAsync();
```

## Generators

Это функции, которые могут приостанавливать свое выполнение и возвращать
промежуточный результат. Их можно использовать для написания асинхронного кода.

```js
function* doSomething() {
    yield setTimeout(() => {
        console.log('doSomething');
        doSomethingElse();
    }, 1000);
}

function doSomethingElse() {
    console.log('doSomethingElse');
}

const iterator = doSomething();
iterator.next();
```

Когда мы ставим `*` после `function` мы говорим, что это функция-генератор.
И внутри функции-генератора мы можем использовать ключевое слово `yield`.
Когда мы вызываем функцию-генератор, она возвращает нам `Iterator`. И мы можем
вызывать метод `next` у этого `Iterator`. И когда мы вызываем метод `next`,
выполняется код до ключевого слова `yield`. 

## Проблемы с асинхронностью в JavaScript
1. Callback Hell
2. Забывание вызвать `Callback`
3. Забывание обработать ошибку
4. Забывание вызвать `resolve` или `reject`
5. Забывание вызвать `next` у `Iterator`

## Callback Hell

```js
function doSomething(callback) {
    setTimeout(() => {
        console.log('doSomething');
        callback();
    }, 1000);
}

function doSomethingElse(callback) {
    setTimeout(() => {
        console.log('doSomethingElse');
        callback();
    }, 1000);
}

function doSomethingElseAgain(callback) {
    setTimeout(() => {
        console.log('doSomethingElseAgain');
        callback();
    }, 1000);
}


doSomething(() => {
    doSomethingElse(() => {
        doSomethingElseAgain(() => {
            console.log('done');
        });
    });
});
```

## Забывание вызвать `Callback`

```js
function doSomething(callback) {
    setTimeout(() => {
        console.log('doSomething');
        callback();
    }, 1000);
}

function doSomethingElse(callback) {
    setTimeout(() => {
        console.log('doSomethingElse');
        callback();
    }, 1000);
}

function doSomethingElseAgain(callback) {
    setTimeout(() => {
        console.log('doSomethingElseAgain');
        callback();
    }, 1000);
}


doSomething(() => {
    doSomethingElse(() => {
        console.log('done');
        doSomethingElseAgain();
    });
});
```

## Забывание обработать ошибку

```js
function doSomething(callback) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('doSomething');
            resolve();
        }, 1000);
    });

}

function doSomethingElse(callback) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('doSomethingElse');
            reject();
        }, 1000);
    });
}

doSomething()
    .then(doSomethingElse)
    .then(() => {
        console.log('done');
    });
```