$(document).ready(function () {
    ajaxExecuteBL();
});

$("#buttonBr").click(function () {
    ajaxExecuteBL();
});

function ajaxExecuteBL() {
    if ($.fn.DataTable.isDataTable('#table-brands')) {
        $('#table-brands').DataTable().destroy();
    }

    $('#table-brands').DataTable({
        "ajax": urlBase + '/getBrandList',
        "columns": [
            { "data": "position" },
            { "data": "name" },
            { "data": "y" }
        ]
    });
};