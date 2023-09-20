# Темы урока: 
* Type casting. coercion and type conversion
* Keyed collections 
* Indexed collections
* Exception handling
* Functions
* * Parameters
* * Arrow functions
* * IIFE
* * Scope and closure
* this keyword
* * in a method
* * in a function
* * in event handlers
* * in arrow functions

## Type casting. 

Type casting - преобразование типов данных.
На самом деле если докопаться, то это не преобразование, а приведение типов.
То есть мы можем представить один тип в виде другого, из-за этого мы приводим типы.

### Coercion

Coercion - приведение типов. Происходит автоматически, когда мы пытаемся сравнить значения разных типов.

```javascript
console.log(1 == '1'); // true
```

Я пытаюсь сравнить число и строку. Поэтому происходит приведение типов. Строка приводится к числу.

### Type conversion

Type conversion - преобразование типов. Происходит явно, когда мы вызываем функцию преобразования типов.

```javascript
console.log(Number('1')); // 1
console.log(String(1)); // '1'
```

## Keyed collections
* Map
* Set
* WeakMap
* WeakSet

### Map

Map - это коллекция, которая хранит данные в виде пар ключ-значение. Ключи могут быть любого типа.

```javascript
const map = new Map();
map.set('name', 'John');
map.set('age', 30);
map.set('name', 'Jane');
map.set(1, 'one');
map.set(true, 'true');
```

Хоть и ключи могут быть любого типа, но в качестве ключей лучше использовать примитивные типы данных.
и чтобы все ваши ключи были одного типа.

Под капотом `map` работает с помощью хеш-таблицы, как мы и привыкли.
Он в любой случае преобразует ключи в `Object` и хранит их в виде строк.

### Set

Set - это коллекция, которая хранит данные в виде уникальных значений. Значения могут быть любого типа.

```javascript
const set = new Set();
set.add('John');
set.add('Jane');
set.add('John');
set.add(1);
```

По сути это массив, в котором не может быть дубликатов, так как он работает через хеш-таблицу.


### WeakMap и WeakSet отличаются от Map и Set тем, что они не удерживают в памяти свои значения, если на них нет ссылок.

То есть если мы создали `WeakMap` и добавили в него какой-то объект, а потом удалили ссылку на этот объект, то `WeakMap` его тоже удалит.

Пример:

```javascript
const map = new WeakMap();
let obj = {name: 'John'};
map.set(obj, 'John');
obj = null;
```

## Indexed collections
* Array
* TypedArray
* String
* NodeList
* HTMLCollection

### Array

Массив - это коллекция, которая хранит данные в виде индексов. Индексы начинаются с 0.

```javascript
const arr = ['John', 'Jane', 'Bob'];
```

### TypedArray

TypedArray - это массив, который хранит данные в виде индексов, но только одного типа.

```javascript
const arr = new Int8Array(3);
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
```

### String

### NodeList

NodeList - это коллекция, которая хранит данные в виде индексов. Индексы начинаются с 0.

```javascript
const nodeList = document.querySelectorAll('div');
```

### HTMLCollection

HTMLCollection - это коллекция, которая хранит данные в виде индексов. Индексы начинаются с 0.

```javascript
const htmlCollection = document.getElementsByTagName('div');
```

Теперь разберемся с разницей между `NodeList` и `HTMLCollection`.

`NodeList` - возвращает все элементы, которые подходят под селектор.
`HTMLCollection` - возвращает только те элементы, которые подходят под селектор и являются элементами DOM.

То есть `HTMLCollection` - это подмножество `NodeList`.

Подмножество - это часть множества, которая содержит все элементы множества.
То есть внутри `NodeList` есть `HTMLCollection`.

## Exception handling
Так же как и в `C#` в `JavaScript` есть `try-catch-finally`.

```javascript
try {
    // code
} catch (error) {
    // code
} finally {
    // code
}
```

Из особенностей `JavaScript` - это то, что в `catch` можно не указывать параметр `error`.

```javascript
try {
    // code
} catch {
    // code
} finally {
    // code
}
```

В приниципе, это все особенности `try-catch-finally` в `JavaScript`.

На счет `Exception` - в `JavaScript` есть только один тип исключения - `Error`.

Можно писать свои исключения, но они будут наследоваться от `Error`.

К приему, в `JavaScript` есть `TypeError`, `ReferenceError`, `SyntaxError` и т.д.

Пример своего исключения:

```javascript
class MyError extends Error {
    constructor(message) {
        super(message);
        this.name = 'MyError';
    }
    
    toString() {
        return `${this.name}: ${this.message}`;
    }
}

throw new MyError('Something went wrong');
```

## Functions

### Parameters
Функции в `js` по умолчанию имеют переменную `arguments`, которая содержит все аргументы, которые были переданы в функцию.

```javascript
function sum() {
    let result = 0;
    for (let i = 0; i < arguments.length; i++) {
        result += arguments[i];
    }
    return result;
}

console.log(sum(1, 2, 3, 4, 5)); // 15
```

Так же в `js` есть `rest` оператор, который позволяет собрать все аргументы в массив.

```javascript
function sum(...args) {
    let result = 0;
    for (let i = 0; i < args.length; i++) {
        result += args[i];
    }
    return result;
}

console.log(sum(1, 2, 3, 4, 5)); // 15
```

### Arrow functions

Стрелочные функции - это синтаксический сахар для обычных функций.

```javascript
const sum = (a, b) => a + b;
```

Стрелочные функции не имеют своего `this`, поэтому они не могут быть использованы как методы объекта.

```javascript
const obj = {
    name: 'John',
    getName: () => this.name,
    secondGetName: function() {
        return this.name;
    }
};

console.log(obj.getName()); // undefined
console.log(obj.secondGetName()); // John
```


### IIFE

IIFE - Immediately Invoked Function Expression - это функция, которая вызывается сразу после объявления.

```javascript
(function() {
    console.log('Hello');
})();
```

Зачем это нужно? Для того, чтобы не засорять глобальную область видимости.

```javascript
(function() {
    const name = 'John';
    console.log(name);
})();
```

По сути, это своего рода небольшой `namespace`.

Мне это понадобилось один раз, когда я писал `react` приложение и
мне нужно было использовать `jQuery` в одном компоненте.


### Scope and closure

Scope - это область видимости. В `js` есть три области видимости - глобальная, локальная, блочная.

```javascript
const name = 'John'; // глобальная область видимости

function getName() {
    const name = 'Jane'; // локальная область видимости
    if (true) {
        const name = 'Bob'; // блочная область видимости
    }
}
```

Разница между локальной и блочной областью видимости в том, что блочная область видимости
видна только внутри блока, а локальная - внутри функции.



Closure - это функция, которая имеет доступ к переменным родительской функции.

```javascript
function getName() {
    const name = 'John';
    return function() {
        return name;
    }
}

const res = getName();

console.log(res()); // John
```

```javascript

function getName() {
    const name = 'John';
    function foo() {
        return name;
    }
    foo();
}
```


Смысл Closure в том, что мы можем создать функцию, которая будет иметь доступ к переменным родительской функции,
Это часто нужно будет при работе с асинхронными функциями.
Например setInterval или setTimeout.

При работе с Promise, мы можем использовать Closure для того, чтобы сохранить состояние промиса.

```javascript
function getPromise() {
    let promise = null;
    return function() {
        if (!promise) {
            promise = new Promise((resolve, reject) => {
                setTimeout(() => {
                    resolve('Hello');
                }, 1000);
            });
        }
        return promise;
    }
}
```

## function borrowing 

```javascript
const obj = {
    name: 'John',
    getName: function() {
        return this.name;
    }
};

const obj2 = {
    name: 'Jane'
};

console.log(obj.getName()); // John

obj2.getName = obj.getName;

console.log(obj2.getName()); // Jane
```

## this keyword

### in a method

```javascript
const obj = {
    name: 'John',
    getName: function() {
        return this.name;
    }
};

console.log(obj.getName()); // John
```

### in a function

```javascript
function getName() {
    return this.name;
}

const obj = {
    name: 'John',
    getName: getName
};

console.log(obj.getName()); // John
```

### in event handlers

```javascript

const button = document.querySelector('button');

button.addEventListener('click', function() {
    console.log(this); // button
});
```

### in arrow functions

```javascript

const button = document.querySelector('button');

button.addEventListener('click', () => {
    console.log(this); // window
});
```
