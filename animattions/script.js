const users = "https://jsonplaceholder.typicode.com/users";
const cardTemplate =
    `
            <div class="card-body">
                <h5 class="card-title">Card title</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <a href="#" id="open-card" class="btn btn-primary">Go somewhere</a>
            </div>
    `

const cardsDiv = document.getElementById("cards");
document.addEventListener("DOMContentLoaded", async () => {

    let usersJson = await fetch(users).then(response => response.json());

    usersJson.forEach(user => {

        let cardStyle =
            {
                'width': '18rem',
                'margin': '5px'
            }

        let card = document.createElement("div");
        card.classList.add("card");

        css(card, cardStyle)

        card.innerHTML = cardTemplate;
        card.querySelector(".card-title").innerText = user.name;
        card.querySelector(".card-text").innerText = user.email;
        card.querySelector("#open-card").addEventListener("click", () => {
            showModal(user);
        })
        cardsDiv.appendChild(card);
    });
});



function css(element, style) {
    for (const property in style)
        element.style[property] = style[property];
}

function showModal(user) {

        let modal = document.querySelector(".my-modal");
        let overlay = document.querySelector(".overlay");

        modal.querySelector("#my-modal-title").innerText = user.name;
        modal.querySelector("#my-modal-desc").innerText = user.email;

        modal.classList.remove("hidden");
        overlay.classList.remove("hidden");

    document.querySelector('#close').addEventListener('click', () => {
        hideModal();
    });

    overlay.addEventListener('click', () => {
        hideModal();
    });

    document.addEventListener('keydown', (e) => {
        if (e.key === 'Escape') {
            hideModal();
        }
    });
}

function hideModal() {

    let modal = document.querySelector(".my-modal");
    let overlay = document.querySelector(".overlay");

    modal.classList.add("hidden");
    overlay.classList.add("hidden");
}