import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { Http } from '@angular/http';

@Component({
 /*remared because we navigate dynamically.
   add to app.module.ts in entryComponents    
  selector: 'page-person',*/
  templateUrl: 'person.html'
})
export class PersonPage {
   
  constructor(public navCtrl: NavController) {

  }
}
