"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var app_component_1 = require("./app.component");
var cities_component_1 = require("./cities/cities.component");
var home_component_1 = require("./home/home.component");
var child_of_router_component_1 = require("./child-of-router/child-of-router.component");
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var page_not_found_component_1 = require("./page-not-found/page-not-found.component");
var appRoutes = [
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'cities', component: cities_component_1.CitiesComponent },
    { path: 'child/:id', component: child_of_router_component_1.ChildOfRouterComponent },
    { path: '**', component: page_not_found_component_1.PageNotFoundComponent }
];
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule,
            router_1.RouterModule.forRoot(appRoutes),
            forms_1.FormsModule
        ],
        declarations: [app_component_1.AppComponent,
            cities_component_1.CitiesComponent,
            home_component_1.HomeComponent,
            child_of_router_component_1.ChildOfRouterComponent,
            page_not_found_component_1.PageNotFoundComponent],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map