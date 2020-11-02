$(document).ready(function(){
		
    var datos = {
        labels : ["Enero", "Febrero", "Marzo", "Abril", "Mayo"],
        datasets : [{
            label : "datos 1",
            backgroundColor : "rgba(220,220,220,0.5)",
            data : [4, 12, 9, 7, 5]
        },
        {

            label : "datos 2",
            backgroundColor : "rgba(151,187,205,0.5)",
            data : [10,7,-5,6,5]
        },
        {
            label : "datos 3",
            backgroundColor : "rgba(151,100,205,0.5)",
            data : [9,6,15,6,17]
        }
        ]
    };


    var canvas = document.getElementById('barras').getContext('2d');
    window.bar = new Chart(canvas, {
        type : "bar",
        data : datos,
        options : {
            elements : {
                rectangle : {
                    borderWidth : 1,
                    borderColor : "rgb(0,255,0)",
                    borderSkipped : 'bottom'
                }
            },
            responsive : true,
            title : {
                display : true,
                text : "Prueba de grafico de barras"
            }
        }
    });

    setInterval(function(){
        var newData = [
            [getRandom(),getRandom(),getRandom(),getRandom()*-1,getRandom()],
            [getRandom(),getRandom(),getRandom(),getRandom(),getRandom()],
            [getRandom(),getRandom(),getRandom(),getRandom(),getRandom()],				
        ];

        $.each(datos.datasets, function(i, dataset){
            dataset.data = newData[i];
        });
        window.bar.update();
    }, 5000);

    


    function getRandom(){
        return Math.round(Math.random() * 100);
    }


});