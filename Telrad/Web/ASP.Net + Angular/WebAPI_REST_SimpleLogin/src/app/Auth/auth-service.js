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
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
var http_1 = require("@angular/http");
var core_1 = require("@angular/core");
var AuthService = (function () {
    function AuthService(http) {
        this.http = http;
        this.m_url = "http://localhost:56744/api/users";
        this.m_isAuthenticated = false;
    }
    AuthService.prototype.Register = function (strEmail, strPassword, strName) {
        var body = {
            Email: strEmail,
            Password: strPassword,
            Name: strName
        };
        this.http.post(this.m_url + "/register", body).subscribe(function (rsp) {
            if (rsp.status == 201) {
                console.log("user created : " + rsp);
            }
            else {
                console.log("error user created: " + rsp);
            }
        }, function (err) {
            console.log("error : " + err);
        });
    };
    AuthService.prototype.Login = function (strEmail, strPassword) {
        var _this = this;
        this.m_isAuthenticated = false;
        var body = {
            Email: strEmail,
            Password: strPassword
        };
        this.http.post(this.m_url + "/login", body).subscribe(function (rsp) {
            if (rsp.status == 200) {
                _this.m_isAuthenticated = true;
                console.log("user is authenticated : " + rsp);
            }
            else {
                console.log("user is not authenticated : " + rsp);
            }
        }, function (err) {
            console.log("error : " + err);
        });
    };
    // --- invoke this ONLY from template !!!!
    AuthService.prototype.IsAuthenticated = function () {
        return this.m_isAuthenticated;
    };
    // --- invoke this ONLY from template !!!!
    AuthService.prototype.GetRole = function () {
        return "";
    };
    AuthService.prototype.LogOff = function () {
        this.m_isAuthenticated = false;
    };
    return AuthService;
}());
AuthService = __decorate([
    __param(0, core_1.Inject(http_1.Http)),
    __metadata("design:paramtypes", [http_1.Http])
], AuthService);
exports.AuthService = AuthService;
//# sourceMappingURL=auth-service.js.map