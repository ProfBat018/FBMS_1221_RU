// console.log('script start');
// function doSomething(num) {
//     return new Promise((resolve, reject) => {
//         setTimeout(() => {
//             console.log('doSomething');
//             if (num % 2 === 0) {
//                 resolve();
//             } else {
//                 reject();
//             }
//         }, 1000);
//     });
// }
//
// function doSomethingElse() {
//     console.log('doSomethingElse');
// }
//
// doSomething(5).then(doSomethingElse).catch(() => {
//     console.log('error')
// });
//


// async function doSomething() {
//     return new Promise((resolve, reject) => {
//         setTimeout(() => {
//             console.log('doSomething');
//             resolve();
//         }, 1000);
//     });
// }
//
// function doSomethingElse() {
//     console.log('doSomethingElse');
// }
//
// async function doSomethingElseAsync() {
//     await doSomething();
//     doSomethingElse();
// }
//
// doSomethingElseAsync();


// function* doSomething() {
//     yield setTimeout(() => {
//         console.log('doSomething');
//         doSomethingElse();
//     }, 1000);
// }
//
// function doSomethingElse() {
//     console.log('doSomethingElse');
// }
//
// const iterator = doSomething();
// iterator.next();


// class Node {
//     constructor(data) {
//         this.data = data;
//         this.next = null;
//     }
// }
// class MyLinkedList {
//     constructor() {
//         this.head = null;
//     }
//
//     addAtHead(data) {
//         const newNode = new Node(data);
//         if (!this.head) {
//             this.head = newNode;
//             return;
//         }
//         newNode.next = this.head;
//         this.head = newNode;
//     }
//
//     *getIterator() {
//         let current = this.head;
//         while (current != null) {
//             yield current.data;
//             current = current.next;
//         }
//     }
// }
//
// const list = new MyLinkedList();
// list.addAtHead(1);
// list.addAtHead(2);
// list.addAtHead(3);
// list.addAtHead(4);
// list.addAtHead(5);
//
// const iterator = list.getIterator();
//
// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());


// function doSomething(callback) {
//     setTimeout(() => {
//         console.log('doSomething');
//         callback();
//     }, 1000);
// }
//
// function doSomethingElse(callback) {
//     setTimeout(() => {
//         console.log('doSomethingElse');
//         callback();
//     }, 1000);
// }
//
// function doSomethingElseAgain(callback) {
//     setTimeout(() => {
//         console.log('doSomethingElseAgain');
//         callback();
//     }, 1000);
// }
//
//
// doSomething(() => {
//     doSomethingElse(() => {
//         console.log('done');
//         doSomethingElseAgain();
//     });
// });


function doSomething(callback) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('doSomething');
            resolve();
        }, 1000);
    });

}

function doSomethingElse(callback) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('doSomethingElse');
            reject();
        }, 1000);
    });
}

doSomething()
    .then(doSomethingElse)
    .then(() => {
        console.log('done');
    }).catch(() => {
    console.log('error');
    });



