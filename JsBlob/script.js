const photoInput = document.getElementById('photoInput');

photoInput.addEventListener('change', (event) => {
    const file = event.target.files[0];
    const blob = new Blob([file], {
        type: 'image/png'
    });
    const image = document.createElement('img');

    image.src = (window.webkitURL || window.URL).createObjectURL(blob);
    document.body.appendChild(image);
});
