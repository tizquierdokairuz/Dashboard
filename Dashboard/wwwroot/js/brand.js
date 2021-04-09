
$(document).ready(function () {
    $('#table-brands').DataTable({
        "ajax": urlBase + '/getBrandList',
        "columns": [
            { "data": "position" },
            { "data": "name" },
            { "data": "y" }
        ]
    });
});