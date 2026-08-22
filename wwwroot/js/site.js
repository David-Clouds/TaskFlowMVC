document.addEventListener("DOMContentLoaded", () => {

    const alert = document.querySelector(".alert-success");

    if (!alert) {
        return;
    }

    setTimeout(() => {

        alert.style.transition = "opacity .5s ease";
        alert.style.opacity = "0";

        setTimeout(() => {
            alert.remove();
        }, 500);

    }, 3500);

});