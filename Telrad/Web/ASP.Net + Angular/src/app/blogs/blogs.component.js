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
var blogs_service_1 = require("./blogs.service");
var blog_1 = require("./blog");
var blog_status_1 = require("./blog-status");
var BlogsComponent = (function () {
    function BlogsComponent(blogsService) {
        this.blogsService = blogsService;
        this.arBlogs = new Array();
    }
    BlogsComponent.prototype.IsGetAllStatus = function () {
        return (this.blogStatus == blog_status_1.BlogStatus.GetAll);
    };
    BlogsComponent.prototype.IsAddBlogStatus = function () {
        return (this.blogStatus == blog_status_1.BlogStatus.AddBlog);
    };
    BlogsComponent.prototype.IsEditBlogStatus = function () {
        return (this.blogStatus == blog_status_1.BlogStatus.EditBlog);
    };
    BlogsComponent.prototype.AddBlogClickHandler = function () {
        this.blogTitle = this.blogDescription = "";
        this.blogStatus = blog_status_1.BlogStatus.AddBlog;
    };
    BlogsComponent.prototype.SubmitAddBlogFormHandler = function (addBlogForm) {
        this.CreateBlog();
    };
    BlogsComponent.prototype.SubmitEditBlogFormHandler = function (addBlogForm) {
        var _this = this;
        var blog = new blog_1.Blog();
        blog.Description = this.blogDescription;
        blog.Title = this.blogTitle;
        blog.Id = this.blogId;
        this.blogsService.EditBlog(blog)
            .subscribe(function (rsp) {
            if (rsp.status == 204) {
                console.log("edit success");
                _this.arBlogs[_this.blogIndex].Description = blog.Description;
                _this.arBlogs[_this.blogIndex].Title = blog.Title;
                _this.blogStatus = blog_status_1.BlogStatus.GetAll;
            }
            else {
                console.log("server responded error : " + rsp);
            }
        }, function (err) {
            console.log("error : " + err);
        });
    };
    BlogsComponent.prototype.EditBlog = function (blogId, index) {
        this.blogId = blogId;
        this.blogIndex = index;
        this.blogTitle = this.arBlogs[index].Title;
        this.blogDescription = this.arBlogs[index].Description;
        this.blogStatus = blog_status_1.BlogStatus.EditBlog;
    };
    BlogsComponent.prototype.CreateBlog = function () {
        var _this = this;
        var blog = new blog_1.Blog();
        blog.Description = this.blogDescription;
        blog.Title = this.blogTitle;
        this.blogsService.CreateBlog(blog)
            .subscribe(function (rsp) {
            if (rsp.status == 201) {
                console.log("create success");
                _this.arBlogs.push(rsp.json());
                _this.blogStatus = blog_status_1.BlogStatus.GetAll;
            }
            else {
                console.log("server responded error : " + rsp);
            }
        }, function (err) {
            console.log("error : " + err);
        });
    };
    BlogsComponent.prototype.DeleteBlog = function (blogId, index) {
        var _this = this;
        this.blogsService.DeleteBlog(blogId)
            .subscribe(function (rsp) {
            if (rsp.status == 200) {
                console.log("delete success");
                _this.arBlogs.splice(index, 1);
                _this.blogStatus = blog_status_1.BlogStatus.GetAll;
            }
            else {
                console.log("server responded error : " + rsp);
            }
        }, function (err) {
            console.log("error : " + err);
        });
    };
    BlogsComponent.prototype.GetBlogs = function () {
        var _this = this;
        this.blogStatus = blog_status_1.BlogStatus.GetAll;
        var req = this.blogsService.GetBlogs();
        req.subscribe(function (rsp) {
            if (rsp.status == 200) {
                _this.arBlogs = rsp.json();
                console.log("get success");
            }
            else {
                console.log("server responded error : " + rsp);
            }
        }, function (err) {
            console.log("error : " + err);
        });
    };
    return BlogsComponent;
}());
BlogsComponent = __decorate([
    core_1.Component({
        selector: 'blogs',
        templateUrl: './blogs.component.html',
        providers: [blogs_service_1.BlogsService]
    }),
    __metadata("design:paramtypes", [blogs_service_1.BlogsService])
], BlogsComponent);
exports.BlogsComponent = BlogsComponent;
//# sourceMappingURL=blogs.component.js.map