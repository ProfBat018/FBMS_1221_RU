function foo(target: any, context: ClassFieldDecoratorContext) {
    console.log(target, context);
}

function foo2(target: any, descriptor: ClassDecoratorContext) {
    console.log(target);
    console.log(descriptor.name);
}

function regex(pattern: RegExp) {

    return function (target: any, context: ClassFieldDecoratorContext): void {
        context.addInitializer(function () {
            const propertyValue = target[context.];
        });
    }
}

// @foo2
class User {
    // @foo
    public name: string;

    @regex(new RegExp("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"))
    public mail: string | null = null;

    get Name(): string {
        return this.name;
    }

    set Name(value: string) {
        this.name = value;
    }

    constructor() {
        this.name = `Elvin`;
    }
}

let a: User = new User();

a.name = "John";

a.mail = "profbat018@gmail.com";