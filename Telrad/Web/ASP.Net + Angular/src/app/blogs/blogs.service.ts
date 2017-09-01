import { Http } from '@angular/http';
import { Inject } from '@angular/core';
import { Blog } from './blog'

export class BlogsService{
 private url = "http://localhost:60910/api/blogs/";
 
constructor(@Inject(Http) private http:Http){}

 GetBlogs() {
    return this.http.get(this.url);
 }

 DeleteBlog(id : number) {
    return this.http.delete(this.url+id);
 }

 CreateBlog(blog : Blog) {
    return this.http.post(this.url,blog);
 }

 EditBlog(blog : Blog) {
    return this.http.put(this.url+blog.Id,blog);
 }
}