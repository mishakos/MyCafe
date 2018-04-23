import * as $ from "jquery";

class clientApi {
    static getAllClients() {
        return fetch("api/clients")
    }
}