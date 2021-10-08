$(function () {
    $.ajax({
        url: "/Home/GetData",
        method: "Get",
        type:"json",
        success: function (data) {
            var Name = [];
            var Qts = [];

            for (var i = 0; i < data.length; i++) {
                Name.push(data[i].name);
                Qts.push(data[i].count);
            }


            Highcharts.chart('container', {
                chart: {
                    type: 'line'
                },
                title: {
                    text: 'Monthly Average Temperature'
                },
                subtitle: {
                    text: 'Source: WorldClimate.com'
                },
                xAxis: {
                    categories: Name
                },
                yAxis: {
                    title: {
                        text: 'Temperature (°C)'
                    }
                },
                plotOptions: {
                    line: {
                        dataLabels: {
                            enabled: true
                        },
                        enableMouseTracking: false
                    }
                },
                series: [{
                    name: 'Tokyo',
                    data: Qts
                    }]
            });
        }


    });


});



