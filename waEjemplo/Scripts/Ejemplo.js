$(GetAllPaises());

function GetAllPaises() {
    jQuery.support.cors = true;
    $.ajax({
        url: 'http://localhost:56176/Api/Pais',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            WriteResponse(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

    function WriteResponse(paises) {
        var strResult = "<table><th>PaisId</th><th>Pais Codigo</th><th>Pais Nombre</th>";
        $.each(paises, function (index, pais) {
            strResult += "<tr><td>" + pais.Id + "</td><td> " + pais.Codigo + "</td><td>" + pais.Nombre + "</td</tr>";
        });
        strResult += "</table>";
        $("#divResult").html(strResult);
    }
