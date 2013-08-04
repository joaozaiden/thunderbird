$.curCSS = $.css;

$.sendAjax = function (url, parametros, sucesso, erro) {
    return $.ajax({
        type: "POST",
        url: url,
        async: true,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: parametros,
        success: sucesso,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //            var exception = XMLHttpRequest.responseText;

            if (erro != undefined || erro != null) {
                erro(errorThrown);
                return;
            }

            if (XMLHttpRequest.status == 401 || XMLHttpRequest.status == 403) {
                window.location = '../Error/SecurityError';
            } else if (XMLHttpRequest.status == 409 && XMLHttpRequest.responseText != "") {
                alertImpromptu(XMLHttpRequest.responseText);
            } else {
                alertImpromptu(feedBackGeneralError);
            }
        }
    });
};

$.sendAjaxPost = function (url, parametros, sucesso, erro) {
    return $.ajax({
        type: "POST",
        url: url,
        async: true,
        contentType: "application/json; charset=utf-8",
        data: parametros,
        success: sucesso,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //            var exception = XMLHttpRequest.responseText;

            if (erro != undefined || erro != null) {
                erro(errorThrown);
                return;
            }

            if (XMLHttpRequest.status == 401 || XMLHttpRequest.status == 403) {
                window.location = '../Error/SecurityError';
            } else if (XMLHttpRequest.status == 409 && XMLHttpRequest.responseText != "") {
                //alertImprompt(XMLHttpRequest.responseText);
                alert(XMLHttpRequest.responseText);
            } else {
                //alertImpromptu(feedBackGeneralError);
                alert(feedBackGeneralError);
            }

            unblock();
        }
    });
};


$.urlParam = function (name) {
    var results = new RegExp('[\\?&]' + name + '=([^&#]*)').exec(window.location.href);
    if (!results) { return 0; }
    return results[1] || 0;
};


// ======== MANIPULACAO DE DATETIME ================= //

//this.GetJSShortDateFromNET = function (date) {
//    return GetShortDate(GetJSDateFromNET(date));
//};


//this.GetJSDateFromNET = function (netDateString) {
//    var netDateString = netDateString.replace("/Date(", "");
//    netDateString = netDateString.replace(")/", "");
//    
//    //var NewTime = parseInt(netDateString) + RemocaoFusoHorario(netDateString);

//    var NewTime = parseInt(netDateString);
//    var toReturn = new Date(NewTime);
//    return toReturn;
//};

////this.RemocaoFusoHorario = function (netDateString) {
////    //Parte do código que remove fuso horário - Implementado por conta do bug ocorrido no Projeto IQM - Ticket #243
////    // -- No caso onde o ajuste do fuso horário deverá ser utilizado, essa remoção de fuso horário deverá ser desabilitada.
////    // -- No caso onde esta data for novamente enviada para o servidor no formato de data e não de string, essa remoção de fuso deverá ser desabilitada ou deverá ser feita uma função inversa na hora do envio da data.

////    var targetTime = new Date();
////    var timeZoneFromClient = -targetTime.getTimezoneOffset(); //time zone value from client
////    var timeZoneFromDB = TIME_ZONE_FROM_DB; //time zone value from database
////    var tzDifference = timeZoneFromDB * 60 - timeZoneFromClient;
////    return (tzDifference * 60 * 1000);
////};

//this.LZ = function (n) {
//    return (n > 9 ? n : '0' + n);
//};

//this.GetShortDate = function (date) {
//    var shortDate = LZ(date.getDate()) + '/' + LZ(date.getMonth() + 1) + '/' + date.getFullYear();
//    return shortDate;
//}

//this.RetornaObjetoDate = function (strData) {
//    var dataQuebrada = strData.split("/");
//    var dataInicio = new Date(dataQuebrada[1] + "/" + dataQuebrada[0] + "/" + dataQuebrada[2]);
//    return dataInicio;
//};

//this.ehDataMinima = function (data) {

//    if (data != undefined) {
//        if (data.toString().indexOf("/Date") != -1) {
//            data = GetJSDateFromNET(data);
//        }
//        return ((data.getFullYear() == 1) || (data.getFullYear() == 0))
//    }
//    else {
//        return false;
//    }
//};

//=================Check if browser is IE9===================//
/****************************START****************************/
function isBrowserIE9() {
    if (isBrowserIE()) {
        var ua = navigator.userAgent;
        var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
        if (re.exec(ua) != null && parseFloat(RegExp.$1) == 9) {
            return true;
        }
    }
    return false;
};

function isBrowserIE7() {
    if (isBrowserIE()) {
        var ua = navigator.userAgent;
        var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
        if (re.exec(ua) != null && parseFloat(RegExp.$1) == 7) {
            return true;
        }
    }
    return false;
};

function isBrowserIE() {
    if (navigator.appName == 'Microsoft Internet Explorer') {
        return true;
    }
    return false;
};
/*****************************END*****************************/
//=================Check if browser is IE9===================//


function cloneObject(obj) {
    var clone = {};
    for (var i in obj) {
        if (typeof (obj[i]) == "object")
            clone[i] = cloneObject(obj[i]);
        else
            clone[i] = obj[i];
    }
    return clone;
};