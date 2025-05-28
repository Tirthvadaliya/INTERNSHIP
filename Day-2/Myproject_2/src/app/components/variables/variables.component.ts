import { Component } from '@angular/core';

@Component({
  selector: 'app-variables',
  standalone: true,
  imports: [],
  templateUrl: './variables.component.html',
  styleUrl: './variables.component.css'
})
export class VariablesComponent {

   FirstName : string = " Tirth ";
   firstName = " ";
   lastName = " patel ";



   users=['user1','user2','user3'];


}
