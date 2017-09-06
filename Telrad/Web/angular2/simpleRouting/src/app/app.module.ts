import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent }  from './app.component';
import { CitiesComponent } from './cities/cities.component'
import { HomeComponent } from './home/home.component'
import { ChildOfRouterComponent } from './child-of-router/child-of-router.component'
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms' ;
import { PageNotFoundComponent } from './page-not-found/page-not-found.component'

const appRoutes: Routes = [
   { path: 'home', component: HomeComponent },
   { path: 'cities', component: CitiesComponent },
   { path: 'child/:id' , component: ChildOfRouterComponent },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule ({
   imports: [ BrowserModule,
   RouterModule.forRoot(appRoutes),
   FormsModule
    ],
   declarations: [  AppComponent,
                    CitiesComponent ,
                    HomeComponent ,
                    ChildOfRouterComponent,
                    PageNotFoundComponent],
   bootstrap: [ AppComponent ]
})
export class AppModule { }