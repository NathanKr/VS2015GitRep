import { Component } from '@angular/core';
import { BlogsService } from './blogs.service'
import { Blog } from './blog'
import { BlogStatus } from './blog-status'

@Component({
  selector: 'blogs',
  templateUrl : './blogs.component.html' ,
  providers :  [ BlogsService ]
})
export class BlogsComponent  {
  
  arBlogs : Blog [];
  blogTitle : string;
  blogDescription : string;
  blogId : number;
  blogIndex : number;
  blogStatus : BlogStatus;

  constructor(private blogsService : BlogsService){
    this.arBlogs = new Array();
  }

IsGetAllStatus(){
  return (this.blogStatus == BlogStatus.GetAll);
}

IsAddBlogStatus(){
  return (this.blogStatus == BlogStatus.AddBlog);
}

IsEditBlogStatus(){
  return (this.blogStatus == BlogStatus.EditBlog);
}

AddBlogClickHandler()
{
  this.blogTitle = this.blogDescription = "";  
  this.blogStatus = BlogStatus.AddBlog;
}




SubmitAddBlogFormHandler(addBlogForm : any)
{
  this.CreateBlog();
}


SubmitEditBlogFormHandler(addBlogForm : any)
{
    let blog = new Blog();
        blog.Description = this.blogDescription;
        blog.Title = this.blogTitle;
        blog.Id = this.blogId;

         this.blogsService.EditBlog(blog)
         .subscribe( rsp => {
                if(rsp.status == 204){
                    console.log("edit success");
                    this.arBlogs[this.blogIndex].Description = blog.Description;
                    this.arBlogs[this.blogIndex].Title = blog.Title;
                    this.blogStatus = BlogStatus.GetAll;
                }
                else{
                    console.log("server responded error : " + rsp);
                }} ,
                (err) => {
                    console.log("error : " + err);
                });
}


EditBlog(blogId : number , index : number){
    this.blogId = blogId;
    this.blogIndex = index;
    this.blogTitle = this.arBlogs[index].Title;
    this.blogDescription = this.arBlogs[index].Description;

    this.blogStatus = BlogStatus.EditBlog;
    }


CreateBlog(){
        let blog = new Blog();
        blog.Description = this.blogDescription;
        blog.Title = this.blogTitle;
        this.blogsService.CreateBlog(blog)
         .subscribe( rsp => {
                if(rsp.status == 201){
                    console.log("create success");
                    this.arBlogs.push(rsp.json());
                    this.blogStatus = BlogStatus.GetAll;
                }
                else{
                    console.log("server responded error : " + rsp);
                }} ,
                (err) => {
                    console.log("error : " + err);
                });
    }



DeleteBlog(blogId : number , index : number){
         this.blogsService.DeleteBlog(blogId)
         .subscribe( rsp => {
                if(rsp.status == 200){
                    console.log("delete success");
                    this.arBlogs.splice(index,1);
                    this.blogStatus = BlogStatus.GetAll;
                }
                else{
                    console.log("server responded error : " + rsp);
                }} ,
                (err) => {
                    console.log("error : " + err);
                });
    }

  GetBlogs(){
        this.blogStatus = BlogStatus.GetAll;
        let req = this.blogsService.GetBlogs();
        req.subscribe( rsp => {
            if(rsp.status == 200)
                {
                    this.arBlogs = rsp.json();
                    console.log("get success");
                }
                else{
                    console.log("server responded error : " + rsp);
                }
        } ,
        (err) =>{
            console.log("error : " + err);
        });
    }

 }
