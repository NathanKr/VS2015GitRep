import { Component } from '@angular/core';
import {Router} from '@angular/router';

@Component ({
   selector: 'my-app',
   template: `

   <ul>
	  <li><a [routerLink] = "['/home']">Home</a></li>
      <li><a [routerLink] = "['/cities']">Cities</a></li>
      <li><a [routerLink] = "['/child/1234']">ChildOfRouter 1234</a></li>  
   </ul>

   <router-outlet></router-outlet>`
})
export class AppComponent  {}