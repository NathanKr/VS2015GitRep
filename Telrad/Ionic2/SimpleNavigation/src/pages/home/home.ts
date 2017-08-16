import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { PersonPage } from '../person/person'


@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
   
  constructor(public navCtrl: NavController) {

  }

  navigateToMyPage()
  {
    this.navCtrl.push(PersonPage);
  }
}
