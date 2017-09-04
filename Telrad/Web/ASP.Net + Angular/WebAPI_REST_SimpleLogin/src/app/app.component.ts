import { Component } from '@angular/core';
import { AuthService } from './auth/auth-service'

@Component({
  selector: 'my-app',
  template: `
    <comp1 *ngIf="auth.IsAuthenticated()"></comp1>
    <comp2 *ngIf="!auth.IsAuthenticated()"></comp2>
    Email : <input type="text"  [(ngModel)]="email"/><br>
    Password : <input type="text"  [(ngModel)]="password"/><br>
    <button (click)="Login()">Login</button>
    <button (click)="Register()">Register</button>
    <button (click)="Logoff()">Logoff</button>
  `
})
export class AppComponent  {
    email : string;
    password : string;
    constructor(private auth : AuthService){}

    Login(){
      this.auth.Login(this.email,this.password);
    }


    Register(){
      this.auth.Register(this.email,this.password,"no one");
    }

    Logoff(){
      this.auth.LogOff();
    }
   }
