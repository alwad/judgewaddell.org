/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />

function awardController($scope: IAwardScope, $http: angular.IHttpService) {
    $http.get('/api/award')
        .success(function (data: IAward[]) {
            $scope.awards = data;
        });

}