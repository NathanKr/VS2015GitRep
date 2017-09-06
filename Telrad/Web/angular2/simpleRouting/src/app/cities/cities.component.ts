import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
selector: 'cities',
template : `
            <h1>This is Cities</h1>
            child number : <input type="text"  [(ngModel)]="childId"/>
            <button (click)="routeDynamically()">route to Child</button>
`
})

export class CitiesComponent  {
    childId = 5;
    constructor(private router : Router){

    }
    
    routeDynamically(){
        this.router.navigate(['/child', this.childId]);
    }
}
