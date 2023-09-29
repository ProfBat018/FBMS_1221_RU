
class User {
    #name;

    constructor(name = 'John Doe', age = 18) {
        this.#name = name;
        this.age = age;
    }

    sayHello() {
        console.log(`Hello, my name is ${this.name}`);
    }

    get name() {
        return this.#name;
    }

    set name(value) {
        if (value.length < 4) {
            console.log('Name is too short');
            return;
        }
        this.#name = value;
    }
}

let user = new User('John', 25);

console.log(user.name);
user.name = 'Bob';
console.log(user.name);




