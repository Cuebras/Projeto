var ProjetoApp = angular.module('ProjetoApp', [`ngRoute`]);

ProjetoApp.controller('LandingPageController', LandingPageController);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/About', {
            templateUrl: '/Templates/About/about.html'
        }).otherwise({ redirectTo: "/Index" });
}
configFunction.$inject = ['$routeProvider'];

ProjetoApp.config(configFunction);