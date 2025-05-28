import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  fname = '';
  lname = '';
  myVar ='';
  email = '';
  number = '';
  address = '';
  // country = '';  // NEW FIELD


  // countries = ['India', 'USA', 'Canada', 'Australia', 'Germany'];  // NEW LIST

  // These hold the submitted data only
  enteredData = {
    fname: '',
    lname: '',
    myVar:'',
    email: '',
    number: '',
    address: '',
    // country: ''  // NEW FIELD IN OBJECT
  };

  Entered = false;

  onSub() {
    this.enteredData = {
      fname: this.fname,
      lname: this.lname,
      myVar: this.myVar,
      email: this.email,
      number: this.number,
      address: this.address,
      // country: this.country  // ASSIGN SELECTED COUNTRY
    };
    this.Entered = true;
  }
}
