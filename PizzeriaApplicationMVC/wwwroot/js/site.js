// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var popover = new bootstrap.Popover(document.querySelector('.my-popover'), {
    container: 'body',
    placement: 'top',
    html: true,
    trigger: 'focus',
    title: 'Kategorier för menyn',
    content: '<div class="p-1"><a id="checkOut" class="btn btn-sm btn-secondary mb-2 w-100">Pizza</a> <br> <a id="checkOut1" class="btn btn-sm btn-secondary mb-2 w-100">Övrigt</a> <br> <a id="checkOut2" class="btn btn-sm btn-secondary mb-2 w-100">Tillbehör</a></div>'
})




$(document).on('click', '#checkOut', function () {
    document.getElementById("pizza1").scrollIntoView();

});
$(document).on('click', '#checkOut1', function () {
    document.getElementById("övrigt").scrollIntoView();
});


$(document).on('click', '#checkOut2', function () {
    document.getElementById("tillbehör").scrollIntoView();
});

var x = window.matchMedia("(max-width: 700px)")

window.onload = function myFunction(x) {
    if (x.matches) { // If media query matches
        var element4 = document.getElementById("fixcardatmobile");
        element4.classList.add("collapse");
    } else {
        var element5 = document.getElementById("fixcardatmobile");
        element5.classList.remove("collapse");
    }
}

