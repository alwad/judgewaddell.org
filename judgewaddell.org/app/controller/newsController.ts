/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />
/// <reference path="../models/newsScope.ts" />


function newsController($scope: INewsScope, $http: angular.IHttpService, $showdown: any) {

    $http.get('/api/news')
        .success(function (data: INews[]) {
            $scope.news = data;
        });

    $scope.MakeHtml = function makeHtml(markdown: string): string {
        return $showdown.makeHtml(markdown);
    };
    
}