//$(document).ready(function () {
//    $("#idSubmit").click(function (evt) {

//        evt.preventDefault();
//        var a = 1;
//        $.ajax({
//            type: 'POST',
//            url: '/Properties/CreateJs',
//            datatype: "Json",
//            async: true,
//            data: {
//                Address: $("#Address").val(),
//                Year_Built: $("#Year_Built").val()
//            },
//            success: function (data) {

//                alertify.alert('Ready!');
//                //window.location.href = '/facPago-management/facPago-details/' + data.id;//action redirect

//            },
//            error: function (error) {
//                console.log(error);
//            }
//        });

//    });
//});