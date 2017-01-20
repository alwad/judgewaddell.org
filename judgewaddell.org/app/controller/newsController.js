/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />
/// <reference path="../models/newsScope.ts" />
function newsController($scope, $http, $showdown) {
    $http.get('/api/news')
        .success(function (data) {
        $scope.news = data;
    });
    $scope.MakeHtml = function makeHtml(markdown) {
        return $showdown.makeHtml(markdown);
    };
}
//# sourceMappingURL=newsController.js.map