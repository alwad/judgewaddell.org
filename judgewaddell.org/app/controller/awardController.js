/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />
function awardController($scope, $http, $showdown) {
    $http.get('/api/award')
        .success(function (data) {
        $scope.awards = data;
    });
    $scope.MakeHtml = function makeHtml(markdown) {
        return $showdown.makeHtml(markdown);
    };
}
