import ko = require("knockout");
import pager = require("pager");
import "./Components";
import "./app.scss";

class Application {
    public run(): void {
        pager.extendWithPage(this);
        ko.applyBindings(this);
        pager.start();
    }
}

let application: Application = new Application();
application.run();