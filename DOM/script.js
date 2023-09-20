// console.log(document);
// console.log(document.documentElement);
// console.log(document.getElementById('head'))
// console.log(document.getElementsByClassName('head'))
// console.log(document.getElementsByTagName('h1'))
// console.log(document.querySelector('.head')) // самый лучший
// console.log(document.querySelectorAll('.head'))
// console.log(document.querySelector('#head'))
// console.log(document.querySelector('h1'))
// console.log(document.getElementsByName('Aloha'));


const searchBtn = document.querySelector('#search-btn');

const heading = document.querySelector('#heading');

console.log(heading.innerText);


// searchBtn.onclick = function () {
//     console.log('click')
// }

// searchBtn.addEventListener('click', function () {
//     console.log('click')
// });


// searchBtn.addEventListener('click', () => {
//     console.log('click')
// });

searchBtn.addEventListener('click', async () => {

    let input = document.querySelector('#city-name');
    let city = input.value;
    let url = `https://api.openweathermap.org/data/2.5/weather?q=${city}&appid=2b1fd2d7f77ccf1b7de9b441571b39b8&units=metric`;

    let res = await fetch(url);
    let data = await res.json();

    console.log(data.main.temp);


    input.value = '';
});




document.querySelector(`#test`).addEventListener('click', () => {
    console.log('click');
});
