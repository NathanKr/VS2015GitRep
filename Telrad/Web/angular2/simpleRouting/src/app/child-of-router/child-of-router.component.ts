import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';


@Component({
selector: 'child-of-route',
template  : `
    <h1>This is ChildOfRoute</h1>
    got id : {{id}}
    `
})



export class ChildOfRouterComponent {
   id : string;
   constructor(private route: ActivatedRoute){}

   ngOnInit() {
   this.id = this.route.snapshot.paramMap.get('id');
   }
}
