$(document).ready(function () {
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: urlBase +'/getBankList',
        error: function () {
            alert("Error de acceso a datos");
        },
        success: function (data) {
            graphicPie(data);
            graphicDonnut(data);
        }
    })
});

function graphicPie(data){
    Highcharts.chart('banks', {
        chart: {
            type: 'variablepie'
        },
        title: {
            text: 'Mejores bancos de Argentina en 2021'
        },
        tooltip: {
            headerFormat: '',
            pointFormat: '<span style="color:{point.color}">\u25CF</span> <b> {point.name}</b><br/>' +
                'Cantidad de usos en millones: <b>{point.y}</b><br/>' +
                'Popularidad de bancos (basado en consultoras 2021): <b>{point.z}</b><br/>'
        },
        series: [{
            minPointSize: 10,
            innerSize: '20%',
            zMin: 0,
            name: 'Entidades',
            data: data
        }]
    });
};

function graphicDonnut(data) {
    Highcharts.chart('bankDonnut', {
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: 0,
            plotShadow: false
        },
        title: {
            text: 'Popularidad<br>Bancos argentinos<br>2021',
            align: 'center',
            verticalAlign: 'middle',
            y: 60
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        },
        accessibility: {
            point: {
                valueSuffix: '%'
            }
        },
        plotOptions: {
            pie: {
                dataLabels: {
                    enabled: true,
                    distance: -50,
                    style: {
                        fontWeight: 'bold',
                        color: 'white'
                    }
                },
                startAngle: -90,
                endAngle: 90,
                center: ['50%', '75%'],
                size: '110%'
            }
        },
        series: [{
            type: 'pie',
            name: 'Entidades',
            innerSize: '50%',
            data: data
        }]
    });
};