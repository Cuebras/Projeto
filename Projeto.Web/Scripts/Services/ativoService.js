"use strict";

(function () {

    var ativoService = function ($resource) {
        return $resource("api/Ativo", {
            GetAtivos: {
                method: 'GET',
                isArray: true,
            }
        });
    }

    var module = angular.module("projeto",[]);
    module.factory("ativoService", ["$resource", ativoService]);
}());
