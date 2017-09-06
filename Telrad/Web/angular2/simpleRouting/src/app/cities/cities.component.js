"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var CitiesComponent = (function () {
    function CitiesComponent(router) {
        this.router = router;
        this.childId = 5;
    }
    CitiesComponent.prototype.routeDynamically = function () {
        this.router.navigate(['/child', this.childId]);
    };
    return CitiesComponent;
}());
CitiesComponent = __decorate([
    core_1.Component({
        selector: 'cities',
        template: "\n            <h1>This is Cities</h1>\n            child number : <input type=\"text\"  [(ngModel)]=\"childId\"/>\n            <button (click)=\"routeDynamically()\">route to Child</button>\n"
    }),
    __metadata("design:paramtypes", [router_1.Router])
], CitiesComponent);
exports.CitiesComponent = CitiesComponent;
//# sourceMappingURL=cities.component.js.map