 Тема урока
* Еще раз про декларацию переменных
* класс Object
* Ключевое слово this
* оператор typeof
* оператор instanceof
* встроенные объекты(built-in objects)
* Prototypal inheritance
* Object prototype
* Преобразование объектов 
* Object.is()
* switch

## Есть три ключевых слова для создания переменных:
* var
* let
* const

Как я говорил на прошлом уроке.
`var` - это способ создания глобальных переменных,
которые доступны везде в коде.

`let` - это способ создания локальных переменных,
по сути создав переменную с помощью `let` мы 
создаем переменную так же, как и в C++ или C#.

`const` - это способ создания констант, которые
нельзя изменить после инициализации. давайте разберемся
на примере:

```javascript

var a = 1;
let b = 2;
const c = 3;

a = 2;
b = 3;
c = 4; // TypeError: Assignment to constant variable.
```

Обычно через `const` создаются переменные, которые
не должны изменяться во время выполнения программы.
При использовании `react` или `vue` обычно используют
`const` для создания переменных, которые хранят ссылки
на DOM элементы. 


## Класс Object

В JavaScript все является объектом, кроме примитивных типов данных.
Например, `string`, `number`, `boolean`, `null`, `undefined` и `symbol`
являются примитивными типами данных. Все остальное является объектом.

Класс `Object` является базовым классом для всех объектов в JavaScript.
Все объекты наследуются от класса `Object`. Класс `Object` имеет несколько
методов, которые доступны для всех объектов. Например, метод `toString()`,
который возвращает строковое представление объекта.

```javascript
const obj = {
    a: 1,
    b: 2,
    c: 3
};

console.log(obj.toString()); // [object Object]
```

Как переопределить метод `toString()` для объекта `obj`?

```javascript

const obj = {
    a: 1,
    b: 2,
    c: 3,
    toString() {
        return `a: ${this.a}, b: ${this.b}, c: ${this.c}`;
    }
};

console.log(obj.toString()); // a: 1, b: 2, c: 3
```

## Ключевое слово this

В `js` с этим все сложно. Казалось бы обычный оператор создает 
много вопросов. Давайте разберемся на примере:

```javascript
const obj = {
    a: 1,
    b: 2,
    c: 3,
    toString() {
        return `a: ${this.a}, b: ${this.b}, c: ${this.c}`;
    }
};

console.log(obj.toString()); // a: 1, b: 2, c: 3
```

В данном примере `this` ссылается на объект `obj`. Но что будет
если мы вызовем метод `toString()` отдельно?

```javascript
const obj = {
    a: 1,
    b: 2,
    c: 3,
    toString() {
        return `a: ${this.a}, b: ${this.b}, c: ${this.c}`;
    }
};

const toString = obj.toString;

console.log(toString()); // a: undefined, b: undefined, c: undefined
```
Если не писать `this`, то `js` будет искать переменные `a`, `b` и `c` внутри функции 

Все дело в том, что `this` ссылается на объект, который вызывает
метод. В данном случае объекта нет, поэтому `this` ссылается на
глобальный объект `window`. Как это исправить?

```javascript
const obj = {
    a: 1,
    b: 2,
    c: 3,
    toString() {
        return `a: ${this.a}, b: ${this.b}, c: ${this.c}`;
    }
};

const toString = obj.toString.bind(obj);

console.log(toString()); // a: 1, b: 2, c: 3
```


И на этом моменте нам надо рассмотреть: 
* `call`
* `apply`
* `bind`

Эти методы позволяют вызвать функцию с указанным контекстом.
Разница между `call` и `apply` в том, что `call` принимает
аргументы через запятую, а `apply` принимает аргументы в виде
массива. `bind` возвращает новую функцию с указанным контекстом.

```javascript
const obj = {
    a: 1,
    b: 2,
    c: 3,
    toString() {
        return `a: ${this.a}, b: ${this.b}, c: ${this.c}`;
    },
    foo(num1, num2) {
        return num1 + num2;
    }
};

const toString = obj.toString.bind(obj); // вернет новую функцию

console.log(toString()); // a: 1, b: 2, c: 3

// foo call 
console.log(obj.foo.call(obj, 1, 2)); // 3

// foo apply
console.log(obj.foo.apply(obj, [1, 2])); // 3
```

На счет применения `call` и `apply` в реальной жизни.

```javascript
const arr = [1, 2, 3, 4, 5];

console.log(Math.max.apply(null, arr)); // 5
console.log(Math.min.apply(null, arr)); // 1
```

## Оператор typeof

Оператор `typeof` возвращает тип операнда. Например:

```javascript
console.log(typeof 1); // number

console.log(typeof 'hello'); // string

console.log(typeof true); // boolean

```

## Оператор instanceof

Оператор `instanceof` проверяет, принадлежит ли объект к определенному классу.

```javascript

class Person {
    constructor(name) {
        this.name = name;
    }
}

const person = new Person('John');

console.log(person instanceof Person); // true
```

## Встроенные объекты

В `js` есть несколько встроенных объектов, которые предоставляют
нам набор методов для работы с данными. Например, `Math`, `Date`, `Array`, `String` и т.д.

```javascript
console.log(Math.max(1, 2, 3, 4, 5)); // 5

console.log(Math.min(1, 2, 3, 4, 5)); // 1

console.log(Math.random()); // 0.123456789
```

## Prototypal inheritance

В `js` есть прототипное наследование. Каждый объект имеет ссылку на прототип.
Прототип - это объект, который используется как шаблон для создания новых объектов.
Пример:

```javascript
const obj = {
    a: 1,
    b: 2,
    c: 3
};

const obj2 = Object.create(obj); // создаем новый объект с прототипом obj

console.log(obj2.a); // 1

console.log(obj2.b); // 2

console.log(obj2.c); // 3
```

## Object prototype

Каждый объект имеет прототип. Прототип - это объект, который используется как шаблон для создания новых объектов.
Прототип объекта можно получить с помощью метода `Object.getPrototypeOf()`.

```javascript

const obj = {
    a: 1,
    b: 2,
    c: 3
};

const obj2 = Object.create(obj); // создаем новый объект с прототипом obj

console.log(Object.getPrototypeOf(obj2)); // {a: 1, b: 2, c: 3}
```

Разница между Object.Create() и Object.getPrototypeOf()

`Object.create()` создает новый объект с указанным прототипом.

`Object.getPrototypeOf()` возвращает прототип объекта.

## Преобразование объектов

JS несколько странно преобразует объекты в примитивные типы данных.
Например:

```javascript

const obj = {
    a: 1,
    b: 2,
    c: 3,
    toString() {
        return `a: ${this.a}, b: ${this.b}, c: ${this.c}`;
    },
    valueOf() {
        return this.a + this.b + this.c;
    }
};

console.log(obj.toString()); // a: 1, b: 2, c: 3

console.log(obj.valueOf()); // 6

console.log(obj + 1); // 7
```

## Object.is()

Метод `Object.is()` сравнивает два значения и возвращает `true` если значения равны.
Например:

```javascript
console.log(Object.is(1, 1)); // true

console.log(Object.is(1, '1')); // false

console.log(Object.is(NaN, NaN)); // true

console.log(Object.is(+0, -0)); // false
```

На счет сравнения. 
* IsStrictlyEqual
* IsLooselyEqual
* SameValueZero
* SameValue

### IsStrictlyEqual

`IsStrictlyEqual` сравнивает два значения и возвращает `true` если значения равны.
Например:

```javascript
console.log(1 === 1); // true

console.log(1 === '1'); // false

console.log(NaN === NaN); // false

console.log(+0 === -0); // true
```

### IsLooselyEqual

`IsLooselyEqual` сравнивает два значения и возвращает `true` если значения равны.

```javascript

console.log(1 == 1); // true

console.log(1 == '1'); // true

console.log(NaN == NaN); // false

console.log(+0 == -0); // true
```

### SameValueZero

`SameValueZero` сравнивает два значения и возвращает `true` если значения равны.

```javascript

console.log(sameValueZero(1, 1)); // true

console.log(sameValueZero(1, '1')); // false

console.log(sameValueZero(NaN, NaN)); // true

console.log(sameValueZero(+0, -0)); // false
```


### SameValue

`SameValue` сравнивает два значения и возвращает `true` если значения равны.

```javascript

console.log(sameValue(1, 1)); // true

console.log(sameValue(1, '1')); // false

console.log(sameValue(NaN, NaN)); // true

console.log(sameValue(+0, -0)); // true
```

## switch

`switch` это оператор, который позволяет сравнивать значение с несколькими вариантами.

Отличия от C++ и C#.

* В `js` можно использовать любые типы данных.
* В `js` можно использовать несколько `case` для одного `case`.
* В `js` можно использовать `default` в любом месте.

```javascript

const a = 1;

switch (a) {
    case 1:
        console.log('a is 1');
        break;
    case 2:
        console.log('a is 2');
        break;
    case 3:
        console.log('a is 3');
        break;
    default:
        console.log('a is not 1, 2 or 3');
        break;
}
```




