import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { AppComponent }  from './app.component';
import { FormsModule } from '@angular/forms';
import { AuthService } from './auth/auth-service'
import { Comp1Component } from './comp1/comp1.component'
import { Comp2Component } from './comp2/comp2.component'

@NgModule({
  imports:      [ BrowserModule  , HttpModule , FormsModule],
  declarations: [ AppComponent , Comp1Component , Comp2Component],
  bootstrap:    [ AppComponent ] ,
  providers: [AuthService ]
  
})
export class AppModule { }
