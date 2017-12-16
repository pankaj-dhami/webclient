(function () {
    var app = angular.module("myApp", ["ngRoute"]);
    app.config(function ($routeProvider) {
        $routeProvider
            .when("/home", {
                templateUrl: "/ClientApp/View/main.html",
                controller : "MainController"
            })
            .when("/red", {
                templateUrl: "red.htm"
            })
            .when("/green", {
                templateUrl: "green.htm"
            })
            .when("/blue", {
                templateUrl: "blue.htm"
            })
            .otherwise({ redirectTo: "/home" });
    });
})();