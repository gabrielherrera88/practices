$(document).ready(function () { //hace uso de jQuery para validar si la pagina fue cargada completamente, el resto del codigo dentro de esta condicion
    //solo se ejecutara cuando la pagina este cargada por completa

    $('.preLoader').fadeOut(); //efecto de jQuery para ocultar un control

    $('#User').focus(); //comando de jQuery para posicionarse en un control y que otme el foco

    $('#btnLogin').on('click', function () { //mecanismo para bindear un evento a un control, en este caso el click, jQuery adjunta un evento al control indicado y le asocia una funcion
        //codigo a ejecutarse cuando se haga click sobre el control
        $('.preLoader').fadeIn();
    });
});