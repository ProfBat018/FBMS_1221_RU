# Часть 3: Интерфейсы
* Types and interfaces
* Extending interfaces
* Interface declaration 
* Hybrid types


## Types and interfaces

В `ts` есть два способа описать типы: `type` и `interface`.

```ts
type User = {
    name: string;
    age: number;
}

interface User {
    name: string;
    age: number;
}
```

Мы в любом случае описываем тип `User`,
но тут надо понять разницу между созданием типа и 
интерфейса. Разница такая же как и в C#

`type` используется для создания типов, 
а `interface` для создания интерфейсов.

вы можете спросить, а как использовать интерфейсы ? 

```ts
interface User {
    name: string;
    age: number;
}

let user: User = {
    name: 'John',
    age: 30
}
```

В чем разница между `type` и `interface` ?

```ts
type User = {
    name: string;
    age: number;
}

interface User {
    name: string;
    age: number;
}

let user: User = {
    name: 'John',
    age: 30
}
```

В данном случае разницы нет. Но есть одно но.

Если вы используете `type` вы можете использовать `union types` и `intersection types`.
А вот если вы используете `interface` вы можете использовать только `intersection types`.

Также `interface` может быть расширен, а `type` нет.
Под словом расширен я подразумеваю наследование.
Про наследование поговорим на теме классы. 

# Hybrid types

Гибридные типы - это типы, которые являются комбинацией двух или более типов.

То есть вы можете создать тип, который будет одновременно и функцией и объектом.
Вы можете спросить зачем это нужно ? 
Ответ конечно не такой и простой.

Их нужно использовать в нескольких случаях:
1. Когда вам нужно создать объект, который должен быть полиморфным.
2. Когда вам нужно делать switch по типу объекта.

```ts

interface Counter {
    // функция с одним параметром типа number 
    // и возвращаемым значением типа string
    (start: number): string;
    interval: number;
    reset(): void;
}

function getCounter(): Counter {
    let counter = function (start: number) {} as Counter;
    counter.interval = 123;
    counter.reset = function () {};
    return counter;
}

let c = getCounter();

c(10);
c.reset();
c.interval = 5.0;
```





