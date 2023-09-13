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

let res = obj + 1;
console.log(`res: ${res}\ttype:${typeof(res)}`); // 7
