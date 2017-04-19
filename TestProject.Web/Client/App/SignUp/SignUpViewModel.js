"use strict";
var ko = require("knockout");
ko.extenders.mail = function (target, flag) {
    target.hasError = ko.observable();
    function validate(newValue) {
        var pattern = /[0-9a-z_]+@[0-9a-z_]+\.[a-z]{2,5}/i;
        var wrongData = flag && newValue && !pattern.test(newValue);
        if (wrongData) {
            target.hasError(true);
            alert("Wrong email format");
        }
    }
    validate(target());
    target.subscribe(validate);
    return target;
};
ko.extenders.required = function (target, flag) {
    target.hasError = ko.observable();
    function validate(newValue) {
        target.hasError(flag === true && !newValue);
        if (flag === true && newValue === "")
            alert("This field is required");
    }
    validate(target());
    target.subscribe(validate);
    return target;
};
var SignUpViewModel = (function () {
    function SignUpViewModel() {
        this.userName = ko.observable("").extend({ required: true });
        this.userSurname = ko.observable("");
        this.userPhone = ko.observable("");
        this.userEmail = ko.observable("").extend({ required: true, email: true });
        this.userPassword = ko.observable("");
        this.userPasswordConfirmation = ko.observable("");
    }
    return SignUpViewModel;
}());
module.exports = SignUpViewModel;
//# sourceMappingURL=SignUpViewModel.js.map