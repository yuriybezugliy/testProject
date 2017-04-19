"use strict";
exports.__esModule = true;
var ko = require("knockout");
var pager = require("pager");
require("./Components");
require("./app.scss");
var Application = (function () {
    function Application() {
    }
    Application.prototype.run = function () {
        pager.extendWithPage(this);
        ko.applyBindings(this);
        pager.start();
    };
    return Application;
}());
var application = new Application();
application.run();
//# sourceMappingURL=App.js.map