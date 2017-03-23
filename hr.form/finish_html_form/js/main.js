/* 
    hr.form
 * 
 * Complete the javascript logic below to make the form functional.
 * See each //todo comment
 * 
 * 
 * 
  */


function initForm() {
    var values = "0:Admin;1:Member;2:Tester";
    var target = $("#ddlRole");
    var vals = values.split(";");

    for (var i = 0; i < vals.length; i++) {
        var parts = vals[i].split(":");

        target.append($('<option />').val(parts[0].trim()).text(parts[1].trim()));
    }

    $("#txtState").autocomplete({
        source: states
    });
}


function getFormData() {
    var inputs = $("form :input");
    var data = $.map(inputs, function (x, y) {
        return {
            Key: x.name,
            Value: $(x).val()
        };
    });
    
    //validate the data, if the data is not valid return false
    if (isFormDataValid(data)) {
        return data;
    }
    return null;
}

$.fn.stateExists = function (data) {
    var success = false;
    var a = data.toString();
    $.map(states, function (obj) {
        var b = obj.label.toString();
        if (a === b) {
            success = true;
        }
    });
    console.log(success);
    return success;
};

function isFormDataValid(data) {
    $.validator.addMethod("lettersonly", function (value, element) {
        return this.optional(element) || /^[a-z ]+$/i.test(value);
    }, "Only alphabetical characters");

    $.validator.addMethod("alreadyexist", function (value, element) {
        return currentUsers.indexOf(value) == -1;
    }, "This user already exists");

    $.validator.addMethod("statelist", function (value, element) {
       return $.fn.stateExists(value);
    }, "This state is invalid");

    $("#frmCreateMember").validate({
        rules: {
            userName: {
                required: true,
                alreadyexist: true
            },
            fName: {
                required: true,
                minlength: 2,
                maxlength: 25,
                lettersonly: true
            },
            lName: {
                required: true,
                minlength: 2,
                maxlength: 25,
                lettersonly: true
            },
            stateName: {
                required: true,
                statelist: true
            }
        },
        messages: {
            userName: {
                required: "Please enter a username"
            },
            fName: {
                required: "Please enter a first name",
                minlength: "Enter at least 2 characters",
                maxlength: "First name too long more than 25 characters"
            },
            lName: {
                required: "Please enter a last name",
                minlength: "Enter at least 2 characters",
                maxlength: "Last name too long more than 25 characters"
            },
            stateName: {
                required: "Please enter a state"
            }
        },
        submitHandler: function (form) {
            form.submit();
            postFormData(data);
        }
    });   
}

function postFormData(data) {
    console.log(data);
    alert("The form was submitted successfully!");

}

/////////////////////////////////////////////////////////////////////////////////
//           Do not modify code below this point
/////////////////////////////////////////////////////////////////////////////////

//list of acceptable states for the state input
var states = [
    { code: "CA", label: "California" },
    { code: "AK", label: "Alaska" },
    { code: "AZ", label: "Arizona" }
];

//Current Usernames that are not allowed to be entered
var currentUsers = ["Billy", "Bob", "Joe"];

function onBtnSubmitClicked() {
    var data = getFormData();
    if (data != null) {
        postFormData(data);
    }
}

$(function () {
    //init the form
    initForm();

    //register the form
    $("#btnSubmit").on('click', onBtnSubmitClicked);
});