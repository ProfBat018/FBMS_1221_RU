const products = document.querySelector('.nav-body');

const productsList = products.querySelectorAll('li');



productsList.forEach((product) => {
    product.addEventListener('mouseover', () => {
        const productLink = product.querySelector('a');
        console.log(`mouseover on ${productLink.innerText}`);
        if (productLink.innerText === 'PRODUCTS') {
            console.log(`mouseover on ${productLink.innerText}`);
            const productDropdown = product.querySelector('.nav-dropdown');
            productDropdown.classList.add('active');
        }
    });
});

