class Image {
    constructor(path, caption) {
        this.path = path;
        this.caption = caption;
    }
}

let slideIndex = 0;
const carousel = document.querySelector('#carousel-content');
const next = document.querySelector('#next');
const prev = document.querySelector('#previous');
const dots = document.querySelector('#dots');

let itemTemplate =
    `  <div class="mySlides fade">
            <img src="{{path}}" style="width:100%">
            <div class="text">{{caption}}</div>
        </div>`;



function createItem(image) {
    return itemTemplate.replace('{{path}}', image.path).replace('{{caption}}', image.caption);
}

const images =
    [
        new Image('../assets/1.jpg', 'First slide'),
        new Image('../assets/2.jpg', 'Second slide'),
        new Image('../assets/3.jpg', 'Third slide')];


window.addEventListener('load', () => {
    let i = 1;
    for (const image of images) {
        carousel.innerHTML += createItem(image);
        dots.innerHTML += `<span id="dot-${i}" class="dot"></span>`;
        i++;
    }

    showSlide();
});


function showSlide() {
    document.querySelectorAll('.mySlides')[slideIndex].style.display = `block`;
}

function nextSlide() {
    document.querySelectorAll('.mySlides')[slideIndex].style.display = `none`;
    slideIndex = (slideIndex + 1) % images.length;
    showSlide();
}

function previousSlide() {
    document.querySelectorAll('.mySlides')[slideIndex].style.display = `none`;
    slideIndex = (slideIndex - 1 + images.length) % images.length;
    showSlide();
}


document.querySelector(`#dots`).addEventListener('click', (event) => {
    let id = event.target.id;
    let index = id.split('-')[1];
    document.querySelectorAll('.mySlides')[slideIndex].style.display = `none`;
    slideIndex = index - 1;
    showSlide();
});








