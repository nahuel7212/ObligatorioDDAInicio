window.onload = load;

function load() {
    document.getElementById("divDatosTracking").style.display = "block";
    document.getElementById("datosMapa").style.display = "none";
}

var latitud = 0;
var longitud = 0;

function GetUbicacion() {
    var numeroTracking = document.getElementById("numeroTracking").value;

    var dataTracking = { numeroTracking: numeroTracking }

    if (numeroTracking == "") {
        $("#errorUbicacion").html("Numero de tracking vacio")
    }
    else {
        $("#errorUbicacion").html("");
        $.ajax({
            url: 'GetUbicacion',
            type: 'POST',
            data: dataTracking,
            success: function (result) {
                if (result.Latitud == null && result.longitud == null) {
                    $("#errorUbicacion").html(result);
                }
                else {
                    document.getElementById("divDatosTracking").style.display = "none";
                    document.getElementById("datosMapa").style.display = "block";

                    Mapatest(result.Latitud, result.Longitud)
                }

            }
        });
    }
}

function Mapatest(lat, long) {

    const map = new google.maps.Map(document.getElementById("dvMap"), {
        zoom: 7,
        center: new google.maps.LatLng(-0.023559, 37.906193),
    });

    var r2 = { lat: parseFloat(lat), lng: parseFloat(long) }; 

    new google.maps.Marker({
        position: r2,
        map,
    });

};