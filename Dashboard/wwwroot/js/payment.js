
$(document).ready(function () {
    $('#table-payments').DataTable({
        "ajax": urlBase + '/getPaymentList',
        "columns": [
            { "data": "position" },
            { "data": "name" },
            { "data": "y" }
        ]
    });
});