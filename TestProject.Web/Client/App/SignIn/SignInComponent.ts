import ko = require("knockout");

ko.components.register('signin', {
    viewModel: require("./SignInViewModel"),
    template: require("./SignInTemplate.html")
});