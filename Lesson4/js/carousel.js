var photoId = 1;
var photoPath = `../assets/${photoId}.webp`;

var image = document.getElementById(`carousel-img`);
var leftBtn = document.getElementById(`left-btn`);
var rightBtn = document.getElementById(`right-btn`);

image.src = photoPath;
image.classList.add(`fade-in`);

leftBtn.onclick = () => {
    leftChangePhoto(photoId);
};

rightBtn.onclick = () => {
    rightChangePhoto();
};

setInterval(() => {rightChangePhoto}, 1000);


function rightChangePhoto() {
    removeAnimations();
    void image.offsetWidth;
    image.classList.add(`fade-in-right`);
    if (photoId >= 6) {
        photoId = 0;
    }    
    photoId++; 
    photoPath = `../assets/${photoId}.webp`;
    image.src = photoPath;
}


function leftChangePhoto() {
    removeAnimations();
    void image.offsetWidth;
    image.classList.add(`fade-in-left`);

    if (photoId <= 1) {
        photoId = 7;
    }       
    photoId--; 
    photoPath = `../assets/${photoId}.webp`;
    image.src = photoPath;
}


function removeAnimations() {
    if (image.classList.contains(`fade-in`)) {
        image.classList.remove(`fade-in`);
    }
    else if (image.classList.contains(`fade-in-right`)) {
        image.classList.remove(`fade-in-right`);
    }
    else if (image.classList.contains(`fade-in-left`)) {
        image.classList.remove(`fade-in-left`);
    }
}