import * as types from "./actionTypes";
import { beginAjaxCall, ajaxCallError } from "./ajaxStatusAction";

export function loadClientsSuccess(clients) {
    return { type: types.LOAD_CLIENT_SUCCESS, clients}
}

export function createClientSuccess(client) {
    return { type: types.CREATE_CLIENT_SUCCESS, client };
}

export function updateClientSuccess(client) {
    return { type: types.UPDATE_CLIENT_SUCCESS, client };
}

export function deleteClientSuccess(client) {
    return { type: types.DELETE_CLIENT_SUCCESS, client };
}

export function loadClients() {
    return function (dispatch) {
        dispatch(beginAjaxCall);
        return 
    }
}