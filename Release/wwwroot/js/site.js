// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
let demora;
let intervalo;
$(function () {
    clearTimeout(demora);
    var actualizarHora = function () {
        var fecha = new Date(),
            hora = fecha.getHours(),
            minutos = fecha.getMinutes(),
            segundos = fecha.getSeconds(),
            diaSemana = fecha.getDay(),
            dia = fecha.getDate(),
            mes = fecha.getMonth(),
            anio = fecha.getFullYear(),
            ampm;

        var $pHoras = $("#horas"),
            $pSegundos = $("#segundos"),
            $pMinutos = $("#minutos"),
            $pAMPM = $("#ampm"),
            $pDiaSemana = $("#diaSemana"),
            $pDia = $("#dia"),
            $pMes = $("#mes"),
            $pAnio = $("#anio");
        var semana = ['Domingo', 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado'];
        var meses = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'];

        $pDiaSemana.text(semana[diaSemana]);
        $pDia.text(dia);
        $pMes.text(meses[mes]);
        $pAnio.text(anio);
        if (hora >= 12) {
            hora = hora - 12;
            ampm = "PM";
        } else {
            ampm = "AM";
        }
        if (hora == 0) {
            hora = 12;
        }
        if (hora < 10) { $pHoras.text("0" + hora) } else { $pHoras.text(hora) };
        if (minutos < 10) { $pMinutos.text("0" + minutos) } else { $pMinutos.text(minutos) };
        if (segundos < 10) { $pSegundos.text("0" + segundos) } else { $pSegundos.text(segundos) };
        $pAMPM.text(ampm);

        var h = document.getElementById("horas").innerHTML;
        var m = document.getElementById("minutos").innerHTML;
        var s = document.getElementById("segundos").innerHTML;
        document.getElementById("hour").innerHTML = h + ":" + m + ":" + s;
    };

    actualizarHora();
    intervalo = setInterval(actualizarHora, 1000);
});

function openForm() {
    document.getElementById("myForm").style.display = "block";
    document.getElementById("pass").focus();
}

function openForm2() {
    document.getElementById("myForm2").style.display = "block";
}

function openForm3() {
    document.getElementById("myForm3").style.display = "block";
    document.getElementById("pass2").focus();
}
function closeForm() {
    document.getElementById("myForm").style.display = "none";
}

function closeForm2() {

    document.getElementById("myForm2").style.display = "none";
}

function closeForm3() {

    document.getElementById("myForm3").style.display = "none";
}
function leerhuella() {
    clearTimeout(demora);
    document.getElementById("mireloj1").style.display = "flex";
    document.getElementById("mireloj1").style.setProperty('--boxAfterBackColor', 'red');
}

function ocultarborde() {
    document.getElementById("mireloj1").style.setProperty('--boxAfterBackColor', 'blue');
    demora = setTimeout(retardo, 2000);
}

function retardo() {
    document.getElementById("mireloj1").style.display = "none";
}

function validacion() {

}

function escribir_dias() {
    var lista = [];
    var lista2 = [];
    var tabla = document.getElementById("MiTabla");
    for (var i in data) {
        lista.push(data[i]);
        console.log(lista[i]);
    }
    for (var i2 in data2) {
        lista2.push(data2[i2]);
        console.log(lista2[i2]);
    }
    if (lista.length > 0) {
        for (var j = 4, m = 0; j >= 0; j--) {
            if (lista[j * 6] != "-") {
                var row = tabla.insertRow(5 - j -m);
                for (var k = 0; k <= 6; k++) {
                    if (k == 0) {
                        cell = row.insertCell(k);
                        cell.innerHTML = lista2[k + j * 6];
                    }
                    else {
                        cell = row.insertCell(k);
                        cell.innerHTML = lista[k - 1 + j * 6];
                    }
                }
            }
            else {
                m++;
            }
        }
    }
}
// Write your JavaScript code.
