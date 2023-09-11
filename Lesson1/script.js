/*
let num = 20;

if (num > 0) {
    let a = 1;
    var b = 2;
    console.log("Number is positive");
} else if(num < 0) {
    console.log("Number is negative");
} else {
    console.log("Number is zero");
}

console.log(b); // 2
console.log(a); // ReferenceError: a is not defined
*/

/*
// let arr = [1, 2, 3, 4, 5];

// for (const arrKey of arr) {
//     console.log(arrKey)
// }

// for (const arrKey in arr) {
//     console.log(arr[arrKey])
// }

// let person = {
//     name: "John",
//     age: 30,
//     weight: 70
// }
//
// for (const personKey in person) {
//     console.log(`${personKey}:\t${person[personKey]}`);
// }
*/


function foo(a, b) {
    console.log(a);
    console.log(b);

    for (const argumentsKey in arguments) {
        console.log(arguments[argumentsKey])
    }
}

// foo(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

// DOM BOM

// console.log(window)



