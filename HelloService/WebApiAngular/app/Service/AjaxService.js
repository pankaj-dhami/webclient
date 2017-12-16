(function () {

    var app = angular.module("myApp");

    var ajaxService = function ($http, $q) {

        var service = {};
        service.getRequest = function (url) {
            var deffered = $q.defer();
            $http.get(url).then(function (response) {
                // promise is fulfilled
                deffered.resolve(response.data);
            }, function (response) {
                deffered.reject(response);
            });
            return deffered.promise;
        }
        return service;

    }
    app.factory("ajaxService", ['$http', '$q', ajaxService])


})();