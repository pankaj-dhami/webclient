(function () {

    var app = angular.module("myApp");
    app.controller("PeopleController", ['$scope', '$q', 'ajaxService', function ($scope, $q, ajaxService) {

        ajaxService.getRequest("https://swapi.co/api/people/").then(function (data) {

            $scope.peoples = data.results;
        },
            function (error) {
                // handle errors here
                console.log(error.statusText);
            })


    }])

})();