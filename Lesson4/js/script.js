var navbarCss = document.getElementById("navbar-css");
var url = window.location.href.split("/Lesson4");

url = url[0];


window.onresize = () => {
    if (window.innerWidth > 1024 && navbarCss.href != `${url}/Lesson4/css/navbar.css`) {
        navbarCss.href = "/Lesson4/css/navbar.css";
    }
    else if (window.innerWidth <= 1024 && navbarCss.href != `${url}/Lesson4/css/navbar-p.css`) {
        navbarCss.href = "/Lesson4/css/navbar-p.css";
    }
};

