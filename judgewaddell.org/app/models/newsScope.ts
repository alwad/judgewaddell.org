/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />

interface INewsScope extends angular.IScope {
    news: INews[];
    MakeHtml(markdown: string): string;
}

interface INews {
    NewsId: number,
    Title: string,
    SubTitle: string,
    Date: Date,
    Text: string,
    Link: string
}