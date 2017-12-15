//https://swapi.co/api/
// http://www.tothenew.com/blog/angularjs-deferred-promises-basic-understanding/

(function () {
    var app = angular.module("myApp", ["ngRoute"]);
    app.config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "/app/View/Main.html",
                controller: "MainController"
            })
            .when("/people", {
                templateUrl: "/app/View/people.html",
                controller: "PeopleController"
            })
            .when("/green", {
                templateUrl: "green.htm"
            })
            .when("/blue", {
                templateUrl: "blue.htm"
            })
            .otherwise({ redirectTo: "/" });
        //$locationProvider.html5Mode({
        //    enabled: true,
        //    requireBase: false
        //});
    });
})();