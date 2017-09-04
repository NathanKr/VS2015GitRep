import { Http } from '@angular/http';
import { Inject } from '@angular/core';
import { UserLogin } from './user-login';


export class AuthService
{
    // ----- todo login - use Observable and change m_isAuthenticated
    // ----- todo register - use Observable

    private m_isAuthenticated : boolean;
    private m_url = "http://localhost:56744/api/users";


    Register(strEmail : string  , strPassword : string , strName : string)
    {

        let body = { 
            Email : strEmail ,
            Password : strPassword,
            Name : strName};

        this.http.post(this.m_url+"/register",body ).subscribe( rsp => {
            if(rsp.status == 201){
                console.log("user created : " + rsp);
            }
            else{
                console.log("error user created: " + rsp);
            }
        } ,
        (err) => {
            console.log("error : " + err);
        });
    }


    Login(strEmail : string  , strPassword : string)
    {
        this.m_isAuthenticated = false;

        let body = { 
            Email : strEmail ,
            Password : strPassword};

        this.http.post(this.m_url+"/login",body ).subscribe( rsp => {
            if(rsp.status == 200){
                this.m_isAuthenticated = true;
                console.log("user is authenticated : " + rsp);
            }
            else{
                console.log("user is not authenticated : " + rsp);
            }
        } ,
        (err) => {
            console.log("error : " + err);
        });
    }


    constructor(@Inject(Http) private http:Http){
        this.m_isAuthenticated = false;
    }


    // --- invoke this ONLY from template !!!!
    IsAuthenticated() 
    {
        return this.m_isAuthenticated;
    }

    // --- invoke this ONLY from template !!!!
    GetRole() 
    {
        return "";
    }

    LogOff()
    {
        this.m_isAuthenticated = false;
    }
}