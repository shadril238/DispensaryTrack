
$(document).ready(function () {
    // Load initial page content
    loadPage('Login.html');

    // Attach event listeners to navbar links
    $('.nav-link').on('click', function (event) {
        event.preventDefault();
        const pageUrl = $(this).attr('href');
        loadPage(pageUrl);
    });
});

function loadPage(url) {
    // Use AJAX or fetch request to load page content
    $.ajax({
        url: url,
        success: function (response) {
            $('#main').html($(response).find('#main').html());
        },
        error: function () {
            $('#main').html('Error loading page.');
        }
    });
}




/* Set the width of the side navigation to 250px and the left margin of the page content to 250px */
function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    document.getElementById("main").style.marginLeft = "250px";
}

/* Set the width of the side navigation to 0 and the left margin of the page content to 0 */
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}



