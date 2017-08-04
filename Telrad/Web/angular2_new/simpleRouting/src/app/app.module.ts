import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent }  from './app.component';
import { CitiesComponent } from './cities.component'
import { HomeComponent } from './home.component'
import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
   { path: 'home', component: HomeComponent },
   { path: 'cities', component: CitiesComponent }
];

@NgModule ({
   imports: [ BrowserModule,
   RouterModule.forRoot(appRoutes)],
   declarations: [  AppComponent,
                    CitiesComponent , HomeComponent],
   bootstrap: [ AppComponent ]
})
export class AppModule { }