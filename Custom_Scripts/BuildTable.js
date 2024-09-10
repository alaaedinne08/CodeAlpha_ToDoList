$(document).ready(function () {
    $.ajax({
        url: '/ToDOes/BuildToDoTable',
        success: function (result) {
            $('#tableDiv').html(result);

        }
    });


});