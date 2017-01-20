/// <reference path="../../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../../scripts/typings/angularjs/angular-route.d.ts" />

interface IAwardScope extends angular.IScope {
    awards: IAward[];
    MakeHtml(markdown: string): string;
}

interface IAward {
    awardDate: Date,
    scholar: string,
    desc: string,
    link: string
}