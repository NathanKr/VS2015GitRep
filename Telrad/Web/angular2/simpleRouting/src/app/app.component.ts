import { Component } from '@angular/core';

@Component ({
   selector: 'my-app',
   template: `
   <ul>
	  <li><a [routerLink] = "['/home']">Home</a></li>
	  <li><a [routerLink] = "['/cities']">Cities</a></li>
   </ul>
   <router-outlet></router-outlet>`
})
export class AppComponent  { }