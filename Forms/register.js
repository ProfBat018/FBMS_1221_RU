
let form = document.querySelector('form');
let result = document.querySelector('#result');


form.addEventListener('submit', async (e) => {
    e.preventDefault();
    const formData = new FormData(event.target);

    await fetch("http://127.0.0.1:8000/register", {method: `POST`, body: formData}).then((Response) => {
        if (!Response.ok) {
            throw new Error(`HTTP error, status = ${Response.status}`);
        }
        return Response.json()
    }).then((data) => {

        if (data.status === 201) {
            result.style.color = '#5cdb95';
        }
        else {
            result.style.color = 'red';
        }
        result.innerHTML = data.message;

    }).catch((err) => {
        result.innerHTML = err;
    });
});