# Тема урока: Классы в JS 

В JS классы используются для создания больших объектов.

В Frontend разработке классы используются для создания компонентов, которые могут быть использованы повторно.
Я вам уже показал на примере `React`, что функциональные компоненты по сути являются классами, которые наследуются от `React.Component`.
Но при если мы не будем учитывать `React`, то классы используются для создания объектов,
которые вы бы не хотели создавать в `JSON`.

Синтаксис классов в JS очень похож на синтаксис классов в Java, C# и других языках программирования.

## Создание класса

Для создания класса используется ключевое слово `class` и имя класса.

```js
class User {
}
```

Поля класса определяются внутри конструктора класса.

```js

class User {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
}
```

Перегрузка конструктора не поддерживается, но можно использовать значения по умолчанию.

```js
class User {
    constructor(name = 'John Doe', age = 18) {
        this.name = name;
        this.age = age;
    }
}
```

чтобы создать метод класса, нужно просто написать его внутри класса, без ключевого слова `function`.

```js
class User {
    constructor(name = 'John Doe', age = 18) {
        this.name = name;
        this.age = age;
    }

    sayHello() {
        console.log(`Hello, my name is ${this.name}`);
    }
}
```

## Создание объекта класса

Для создания объекта класса используется ключевое слово `new`.

```js
const user = new User('John Doe', 18);
```

## Наследование

Для наследования класса от другого класса используется ключевое слово `extends`.

```js
class Admin extends User {
    constructor(name, age, role) {
        super(name, age);
        this.role = role;
    }
}
```

Ключевое слово `super` - это тоже самое что и `base` в C#.

Множественное наследование не поддерживается, но можно использовать интерфейсы.

## Интерфейсы

Интерфейсы в JS - это просто объекты, которые содержат в себе методы,
которые должны быть реализованы в классе.

По умолчанию интерфесов нет, но таким образом мы симулируем интерфейсы.

```js

// обычный JSON объект
const IAdmin = {
    sayHello() {
        console.log('Hello, I am admin');
    }
}

class Admin extends User {
    constructor(name, age, role) {
        super(name, age);
        this.role = role;
    }
}

Object.assign(Admin.prototype, IAdmin);

const admin = new Admin('John Doe', 18, 'admin');

admin.sayHello();
```

## Статические методы

Статические методы - это методы, которые можно вызвать без создания объекта класса.

```js

class User {
    constructor(name = 'John Doe', age = 18) {
        this.name = name;
        this.age = age;
    }

    sayHello() {
        console.log(`Hello, my name is ${this.name}`);
    }

    static create(name, age) {
        return new User(name, age);
    }
}

const user = User.create('John Doe', 18);
```

## Геттеры и сеттеры

Геттеры и сеттеры - это методы, которые позволяют получить и установить значения полей класса.

```js

class User {
    constructor(name = 'John Doe', age = 18) {
        this.name = name;
        this.age = age;
    }

    sayHello() {
        console.log(`Hello, my name is ${this.name}`);
    }

    static create(name, age) {
        return new User(name, age);
    }

    get name() {
        return this._name;
    }

    set name(value) {
        this._name = value;
    }
}

const user = User.create('John Doe', 18);

user.name = 'Jane Doe';
```

Тут надо отметить работу с модификаторами доступа.

## Модификаторы доступа

Модификаторы доступа - это ключевые слова, которые позволяют ограничить доступ к полям и методам класса.

В JS есть 3 модификатора доступа: `public`, `private`, `protected`.

`public` - это модификатор доступа по умолчанию, он не пишется явно, но он есть.

`private` - это модификатор доступа, который ограничивает доступ к полю или методу класса только внутри класса.

`protected` - это модификатор доступа, который ограничивает доступ к полю или методу класса только внутри класса и его наследников.

```js

class User {
    constructor(name = 'John Doe', age = 18) {
        this.name = name;
        this.age = age;
    }

    sayHello() {
        console.log(`Hello, my name is ${this.name}`);
    }

    static create(name, age) {
        return new User(name, age);
    }

    get name() {
        return this._name;
    }

    set name(value) {
        this._name = value;
    }
}

```

Чтобы сделать `private` поле или метод, нужно добавить перед ним символ `#`.

Чтобы сделать `protected` поле или метод, нужно добавить перед ним символ `_`.

`Object.prototype` - это объект, который является прототипом всех объектов в JS.

`proto` - это поле, которое указывает на прототип объекта.

```js

class User {
    constructor(name = 'John Doe', age = 18) {
        this.name = name;
        this.age = age;
    }

    sayHello() {
        console.log(`Hello, my name is ${this.name}`);
    }

    static create(name, age) {
        return new User(name, age);
    }

    get name() {
        return this._name;
    }

    set name(value) {
        this._name = value;
    }
}

const user = User.create('John Doe', 18);

console.log(user.__proto__ === User.prototype); // true

let new_user = user.__proto__;

console.log(new_user.__proto__ === User.prototype); // true

new_user.name = 'Jane Doe';

console.log(user.name); // Jane Doe
```

