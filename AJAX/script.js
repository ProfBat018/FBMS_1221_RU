// let xhr = new XMLHttpRequest();
//
// xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
//
// xhr.send();
//
// xhr.onload = function () {
//     if (xhr.status !== 200) {
//         console.log(xhr.status + ': ' + xhr.statusText);
//     } else {
//         let response = JSON.parse(xhr.responseText);
//         console.log(response);
//     }
// }
//


// 1 вариант
// fetch('https://jsonplaceholder.typicode.com/users')
//     .then(response => {
//         if (response.status !== 200) {
//             throw new Error('Error');
//         }
//         return response.json();
//     })
//     .then(data => console.log(data));


// 2 вариант
// async function getUsers() {
//     let res = await fetch('https://jsonplaceholder.typicode.com/users')
//
//     let data = await res.json();
//     console.log(data);
// }


// getUsers();




