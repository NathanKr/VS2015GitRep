import { Component } from '@angular/core';
import { AuthService } from './services/auth.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [AuthService]

})
export class AppComponent {
  title = 'app';

  constructor(private auth : AuthService){
  }

  Login()
  {
    this.auth.login();
  }
}
