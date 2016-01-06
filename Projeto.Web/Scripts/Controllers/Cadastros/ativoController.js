"use strict";

(function () {
    var module = angular.module("projeto");

    var ativoController = function ($scope, $routeParams, ativoService) {
        //$scope.ativos = ativoService.GetAtivos();
              
    };

    module.controller("ativoController", ["$scope", "$routeParams", "ativoService", ativoController]);

}());

