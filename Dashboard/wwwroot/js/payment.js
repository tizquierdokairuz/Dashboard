$(document).ready(function () {
    ajaxExecutePL();
});

$("#buttonPa").click(function () {
    ajaxExecutePL();
});

function ajaxExecutePL() {
    if ($.fn.DataTable.isDataTable('#table-payments')) {
            $('#table-payments').DataTable().destroy();
     }

    $('#table-payments').DataTable({
        "ajax": urlBase + '/getPaymentList',
        "columns": [
            { "data": "position" },
            { "data": "name" },
            { "data": "y" }
        ]
    });
};