
class User {
    @foo
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


function foo(target: any, key: string) {
    console.log(`${target}: ${key}`);
}

let a: User = new User(`Elvin`, 21, true);


a.name = 'Samir';

