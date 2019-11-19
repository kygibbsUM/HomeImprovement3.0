// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var menuHeader = document.querySelector('.menu-header');
var menuContainer = document.querySelector('.menu-container');

menuHeader.addEventListener('click', function () {
    menuContainer.classList.toggle('active');
});

// Flickity Init
var flkty = new Flickity('.main-carousel', {
    draggable: false,
    prevNextButtons: false,
    pageDots: false,
    adaptiveHeight: true
});

var gotoNewPermissions = document.querySelector('#goto-new-permissions');
gotoNewPermissions.addEventListener('click', function () {
    document.querySelector('.manage-permissions').style.display = 'block';
    flkty.next();
});

var gotoDelete = document.querySelector('#goto-delete');
gotoDelete.addEventListener('click', function () {
    document.querySelector('.manage-permissions').style.display = 'none';
    flkty.selectCell('.confirm-delete-item');
});

var gotoPrevious = document.querySelector('.arrow-previous');
gotoPrevious.addEventListener('click', function () {
    flkty.selectCell('.main-menu');
});

var gotoPreviousFromDelete = document.querySelector('.arrow-previous-delete');
gotoPreviousFromDelete.addEventListener('click', function () {
    flkty.selectCell('.main-menu');
});