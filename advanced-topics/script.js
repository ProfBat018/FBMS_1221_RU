class A {
    constructor() {
        this.value = 1;
    }

    *generator() {
        yield this.value++;
    }
}

const a = new A();

console.log(a.generator().next().value)
console.log(a.generator().next().value)
console.log(a.generator().next().value)
console.log(a.generator().next().value)