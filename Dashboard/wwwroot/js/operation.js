$(document).ready(function () {
    ajaxExecuteOL("");
});

$("#buttonOp").click(function () {
    ajaxExecuteOL("operations");
});
$("#buttonOp2").click(function () {
    ajaxExecuteOL("lineOperations");
});
function ajaxExecuteOL(operations) {
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: urlBase +'/getOperationList',
        error: function () {
            alert("Error de acceso a datos");
        },
        success: function (data) {
            if (operations === "operations")
                graphicOperation(data);
            else if (operations === "lineOperations")
                lineOperation(data);
            else {
            graphicOperation(data);
                lineOperation(data);
            }
        }
    })
};

function graphicOperation(data){
    Highcharts.chart('operations', {

        chart: {
            polar: true,
            type: 'line'
        },

        accessibility: {
            description: '.'
        },

        title: {
            text: 'Personas físicas vs Jurídicas',
            x: -80
        },

        pane: {
            size: '80%'
        },

        xAxis: {
            categories: ['Compras al contado', 'Pagos con tarjeta', 'Compra Venta Moneda extranjera', 'Créditos hipotecarios', 'Compra venta de inmuebles', 'Alquileres'],
            tickmarkPlacement: 'on',
            lineWidth: 0
        },

        yAxis: {
            gridLineInterpolation: 'polygon',
            lineWidth: 0,
            min: 0
        },

        tooltip: {
            shared: true,
            pointFormat: '<span style="color:{series.color}">{series.name}: <b>${point.y:,.0f}</b><br/>'
        },

        legend: {
            align: 'right',
            verticalAlign: 'middle',
            layout: 'vertical'
        },

        series: data,

        responsive: {
            rules: [{
                condition: {
                    maxWidth: 500
                },
                chartOptions: {
                    legend: {
                        align: 'center',
                        verticalAlign: 'bottom',
                        layout: 'horizontal'
                    },
                    pane: {
                        size: '70%'
                    }
                }
            }]
        }

    });
}
function lineOperation(data) {
    Highcharts.chart('lineOperations', {
        chart: {
            type: 'area'
        },
        title: {
            text: 'Personas físicas vs Jurídicas',
        },
        legend: {
            layout: 'vertical',
            align: 'left',
            verticalAlign: 'top',
            x: 100,
            y: 70,
            floating: true,
            borderWidth: 1,
            backgroundColor:
                Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF'
        },
        xAxis: {
            categories: ['Compras al contado', 'Pagos con tarjeta', 'Compra Venta Moneda extranjera', 'Créditos hipotecarios', 'Compra venta de inmuebles', 'Alquileres'],
        },
        yAxis: {
            title: {
                text: 'Y-Axis'
            }
        },
        plotOptions: {
            area: {
                fillOpacity: 0.5
            }
        },
        credits: {
            enabled: false
        },
        series: data
    });
}