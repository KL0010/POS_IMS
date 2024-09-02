
$(document).ready(function () {
    var urlUsername = '@Url.Action("GetUsername", "Api")';
    var urlEmail = '@Url.Action("GetEmail", "Api")';
    var urlMobile = '@Url.Action("GetMobile", "Api")';
    $("#username").focus(function () {
        if ($("#username").val().length > 0) {
            $("#username").val('');
        }
    });
    $("#email").focus(function () {
        if ($("#email").val().length > 0) {
            $("#email").val('');
        }
    });
    $("#mobile").focus(function () {
        if ($("#mobile").val().length > 0) {
            $("#mobile").val('');
        }
    });
    $("#username").on("change", function () {
        $.ajax({
            url: urlUsername,
            type: 'Post',
            dataType: 'json',
            data: { 'username': $("#username").val() },
            success: function (response) {
                if (response == true) {
                    $('#usernameDanger').text("Username already Exist. Please enter another...");
                }
            }
        });
    });
    $("#email").on("change", function () {
        $.ajax({
            url: urlEmail,
            type: 'Post',
            dataType: 'json',
            data: { 'email': $("#email").val() },
            success: function (response) {
                if (response == true) {
                    $('#emailDanger').text("Email already Exist. Please enter another...");
                }
            }
        });
    });
    $("#mobile").on("change", function () {
        $.ajax({
            url: urlMobile,
            type: 'Post',
            dataType: 'json',
            data: { 'phoneNumber': $("#mobile").val() },
            success: function (response) {
                if (response == true) {
                    $('#mobileDanger').text("Phone number already Exist. Please enter another...");
                }
            }
        });
    })
});