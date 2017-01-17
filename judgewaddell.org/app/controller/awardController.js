/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />
function awardController($scope, $http) {
    $http.get('/api/award')
        .success(function (data) {
        $scope.awards = data;
    });
}
//# sourceMappingURL=awardController.js.map