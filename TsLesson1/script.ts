function foo() : void {
    console.log("Hello World");
}

function foo2() : never {
    console.log("Hello World");

    throw new Error("Error");
}