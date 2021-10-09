$(function ()

{
    debugger;
    $.ajax({
       

        url: "/Home/GetData",
        type: "json",
        method: "Get",

        success: function (data) {


            var Name = [];
            var Qts = [];

            for (var i = 0; i < data.length; i++) {
                Name.push(data[i].name);
                Qts.push(data[i].count);
            }

            debugger;
            var ctx_bar = document.getElementById("myBarChat");

            debugger;
            var MyBarChart = new Chart(ctx_bar, {

                debugger:true,
                type: 'bar',
                data: {

                    labels: Name,
                    datasets: [{

                        label: 'Earning',
                        backgroundColor: "rgba(255,99,132,0.2)",
                        borderColor: "rgba(255,99,132,1)",
                        borderWidth: 2,
                        hoverBackgroundColor: "rgba(255,99,131,0.4)",
                        hoverBorderColor: "rgba(255,99,131,1)",
                        data: Qts


                    }]

                }


            });

        }


    });


});


