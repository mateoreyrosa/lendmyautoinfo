var update = false; 
$(document).ready(function () {
    // Transition effect for navbar
    $(window).scroll(function () {
        // checks if window is scrolled more than 500px, adds/removes solid class
        if ($(this).scrollTop() > 10 || update == true) {
            $('.navbar').addClass('solid');
        } else {
            $('.navbar').removeClass('solid');
        }
    });
    
});

function SolidNav() {
    if (update == true) {
        $('.navbar').removeClass('solid');
        update = false;
    } else {
        update = true;
        $('.navbar').addClass('solid');
    }
}