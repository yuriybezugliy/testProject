import ko = require("knockout");

ko.extenders.mail = function(target, flag) {
    target.hasError = ko.observable();

    function validate(newValue) {
        let pattern = /[0-9a-z_]+@[0-9a-z_]+\.[a-z]{2,5}/i;
        ///^[-._a-z0-9]+@(?:[a-z0-9][-a-z0-9]+\.)+[a-z]{2,6}$/;
        let wrongData = flag && newValue && !pattern.test(newValue)
        if (wrongData) {
            target.hasError(true);
            alert("Wrong email format");
        }
    }

    validate(target());

    target.subscribe(validate);

    //return the original observable
    return target;
};

ko.extenders.required = function(target, flag) {
    target.hasError = ko.observable();

    function validate(newValue) {
        target.hasError(flag === true && !newValue);
        if (flag === true && newValue === "")
            alert("This field is required");
    }

    validate(target());

    target.subscribe(validate);

    //return the original observable
    return target;
};



class SignUpViewModel {
    public userName: KnockoutObservable<string>;
    public userSurname: KnockoutObservable<string>;
    public userPhone: KnockoutObservable<string>;
    public userEmail: KnockoutObservable<string>;
    public userPassword: KnockoutObservable<string>;
    public userPasswordConfirmation: KnockoutObservable<string>;

    constructor() {
        this.userName = ko.observable("").extend({required: true});
        this.userSurname = ko.observable("");
        this.userPhone = ko.observable("");
        this.userEmail = ko.observable("").extend({ required: true, email: true});
        this.userPassword = ko.observable("");
        this.userPasswordConfirmation = ko.observable("");
    }

    //this.onSubmit.bind(this);
}

export = SignUpViewModel;