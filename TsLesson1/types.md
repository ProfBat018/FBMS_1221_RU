# Тема урока: Typescript часть 2

## Combining types
* Union types
* Intersection types
* Type guards
* Type aliases
* keyof operator

***Union types***

```ts
let a: number | string = 1;
```

`a` может быть либо `number`, либо `string`.
Я уже не в первый раз использую данное написание.
Дело в том, что в `ts` можно давать переменной 
не только один тип, но и несколько.

То есть по умолчанию `a` имеет тип `number | string`.

***Intersection types***

```ts
let a: number & string = 1;
```

`a` может быть либо `number`, либо `string`.

В отличие от `Union types`, `Intersection types` 
позволяет использовать оба типа одновременно.

Общая разница между `Union types` и `Intersection types`
в том, что `Union types` - это `OR`, а `Intersection types` - это `AND`.

В первом случае вы можете использовать один тип или другой.
Во втором случае вы можете использовать оба типа одновременно.

Чтобы использовать оба типа одновременно нужно понять как будет 
работать преобразование типов.

```ts
let a: number & string = 1;

let b: number = a;
let c: string = a;
```

***Type guards***

Type guards - это способ проверить тип переменной.

```ts

let a: number | string = 1;

if (typeof a === 'number') {
    let b: number = a;
} else {
    let c: string = a;
}
```

В данном случае `typeof a === 'number'` - это type guard.

***Type aliases***

Type aliases - это возможность создавать свои типы.

```ts

type MyType = number | string;

let a: MyType = 1;

let b: MyType = '1';
```

По сути в данном случае это тоже самое что и define в С++
или alias в SQL

***keyof operator***

keyof operator - это возможность получить все ключи объекта.



```ts

type MyType = {
    a: number;
    b: string;
};

let a: keyof MyType = 'a';
```

В данном случае в переменную `a` попадет `'a' | 'b'`.
То есть он будет иметь тип `number` | `string`.

## Narrowing
* Equality narrowing
* Truthiness narrowing
* Type predicates

***Equality narrowing***

narrowing - это возможность сужать тип переменной.
Equality narrowing - это сужение типа переменной с помощью оператора `===`.

```ts

let a: number | string = 1;

if (a === 1) {
    let b: number = a;
} else {
    let c: string = a;
}
```

***Truthiness narrowing***

Truthiness narrowing - это сужение типа переменной с помощью приведения к `boolean`.

```ts

let a: number | string = 1;
if (a) {
    let b: number = a;
} else {
    let c: string = a;
}
```

***Type predicates***

Type predicates - это сужение типа переменной с помощью `instanceof`.

```ts

class A {
    a: number = 1;
}

class B {
    b: string = '1';
}

let a: A | B = new A();

if (a instanceof A) {
    let b: A = a;
} else {
    let c: B = a;
}
```

## Typescript functions
* Function types    
* Function overloading 

Теперь поговорим про вещи, которые я люблю в `ts` ❤️❤️❤️

***Function types***

Это возможность функций возвращать типы.

```ts

function a(): number {
    return 1;
}

let b: number = a();
```

Функции также могут возвращать типы в формате `Union types`.

```ts

function a(): number | string {
    return 1;
}
```

***Function overloading***

Ну вы знаете что это такое 

```ts

function a(): number {
    return 1;
}
function a(): string {
    return '1';
}
function a(): number | string {
    return 1;
}
```


