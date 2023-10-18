# Тема урока: классы в typescript 

Что такое классы, вы уже знаете. Рассмотрим их в typescript.

## Синтаксис

```typescript
class User {
    name: string;
    age: number;
    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }
    sayHi() {
        console.log(`Hi, I am ${this.name}`);
    }
}
```

Как вы видите мы создаем поля с явными типами, это не обязательно, но это хорошая практика.
Конструктор принимает два параметра, и присваивает их полям класса.
Можно сделать перегрузку конструктора. Пример:

```typescript

class User {
    name: string;
    age: number;
    constructor(name: string, age: number);
    constructor(name: string, age: number, isAdmin: boolean) {
        this.name = name;
        this.age = age;
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name}`);
    }
}
```

В методе `sayHi` не написан возращаемый тип, но он есть. Это `void`.
Я вам не советую так делать. По поему мнению вам надо всегда писать типы.

## Access Modifiers 
* public
* private
* protected

```typescript
class User {
    public name: string;
    private age: number;
    protected isAdmin: boolean;
    
    constructor(name: string, age: number, isAdmin: boolean) {
        this.name = name;
        this.age = age;
        this.isAdmin = isAdmin;
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name}`);
    }
}
```

По усолчанию, то есть если вы не написали модификатор доступа, то он будет `public`.

## Abstract classes

```typescript
abstract class User {
    public name: string;
    private age: number;
    protected isAdmin: boolean;
    
    constructor(name: string, age: number, isAdmin: boolean) {
        this.name = name;
        this.age = age;
        this.isAdmin = isAdmin;
    }
    abstract sayHi() : void;
}
```

Абстрактный клас - это класс который нельзя создать,
наследники абстрактного класса должны реализовать все абстрактные методы.

Чтобы сделать метод абстрактным нужно написать `abstract` перед ним.

Чтобы наследоваться от класса нужно написать `extends` после имени класса.

```typescript

class Admin extends User {
    sayHi() : void {
        console.log(`Hi, I am ${this.name} and I am admin`);
    }
}
```

В данном случае происходит наследование от класса `User` и 
переопределение метода `sayHi`.

А что с виртуальными методами ? В typescript их нет. 

Полиморфизм в `ts` не совсем такой как в остальных языках.

Перегрузка операторов в `ts` не поддерживается.

Из статичного полиморфизма поддерживается только перегрузка методов.
Из динамического полиморфизма поддерживается только переопределение методов.

Нельзя наследоваться от нескольких классов.
Делегирование конструктора делается с помощью `super`.

```typescript

class Admin extends User {
    constructor(name: string, age: number) {
        super(name, age, true);
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name} and I am admin`);
    }
}
```

## Generics

Generics - это параметризация типов.

```typescript

class User<T> {
    public name: string;
    private age: number;
    protected isAdmin: boolean;
    public data: T;
    
    constructor(name: string, age: number, isAdmin: boolean, data: T) {
        this.name = name;
        this.age = age;
        this.isAdmin = isAdmin;
        this.data = data;
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name}`);
    }
}
```

В принципе `Generics` здесь, это тоже самое что и в `C#`.

Можно фильтровать типы.

```typescript

class User<T extends string | number> {
    public name: string;
    private age: number;
    protected isAdmin: boolean;
    public data: T;
    
    constructor(name: string, age: number, isAdmin: boolean, data: T) {
        this.name = name;
        this.age = age;
        this.isAdmin = isAdmin;
        this.data = data;
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name}`);
    }
}
```

В данном примере `T` может быть только `string` или `number`.
Это аналог ключевого слова `where` в `C#`.

Вы можете подставить туда интерфейс.

```typescript

interface IUser {
    name: string;
    age: number;
}

class User extends IUser {
    
}
class Admin extends IAdmin {
    
}

class UserManager<T extends IUser> {
    public name: string;
    private age: number;
    protected isAdmin: boolean;
    public data: T;
    
    constructor(name: string, age: number, isAdmin: boolean, data: T) {
        this.name = name;
        this.age = age;
        this.isAdmin = isAdmin;
        this.data = data;
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name}`);
    }
}
```

## Decorators

Декораторы - это функции которые применяются к классам, методам, свойствам и т.д.

```typescript

function log(target: any, key: string, descriptor: PropertyDescriptor) {
    console.log(target, key, descriptor);
}

class User {
    
    @log
    public name: string;
    private age: number;
    protected isAdmin: boolean;
    
    constructor(name: string, age: number, isAdmin: boolean) {
        this.name = name;
        this.age = age;
        this.isAdmin = isAdmin;
    }
    sayHi() : void {
        console.log(`Hi, I am ${this.name}`);
    }
}

```

В данном примере мы создали декоратор `log` и применили его к свойству `name`.
И каждый раз когда мы будем обращаться к полю `name` будет вызываться функция `log`.


