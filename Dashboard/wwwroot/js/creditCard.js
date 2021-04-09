$(document).ready(function () {
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: urlBase + '/getCreditCardList',
        error: function () {
            alert("Error de acceso a datos");
        },
        success: function (data) {
            graphicBars(data);
        }
    })
});

function graphicBars(data) {
Highcharts.chart('creditCards', {
    chart: {
        type: 'column'
    },
    title: {
        text: 'Ranking de tarjetas de crédito 2021'
    },
    subtitle: {
        text: 'Fuente: <a href="https://www.rankia.com.ar/blog/mejores-plazos-fijos/3447565-mejores-bancos-argentina-2021" target="_blank">Mejores Bancos Argentina 2021</a>'
    },
    accessibility: {
        announceNewData: {
            enabled: true
        }
    },
    xAxis: {
        type: 'Tarjetas'
    },
    yAxis: {
        title: {
            text: 'Movimientos'
        }

    },
    legend: {
        enabled: false
    },
    plotOptions: {
        series: {
            borderWidth: 0,
            dataLabels: {
                enabled: true,
                format: '{point.y:.1f}%'
            }
        }
    },

    tooltip: {
        headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
        pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y:.2f}%</b> del total<br/>'
    },

    series: [
        {
            name: "Tarjetas",
            colorByPoint: true,
            data: data
        }
    ]
});
}