import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit{ 

  Roles: any = [
    {"id": 1, "name": "Teacher"},
    {"id": 2, "name": "Student"}, 
    {"id": 3, "name": "Admin"}
  ];  

  public selected = this.Roles[0].id;

    constructor() { }
  
    ngOnInit() {
    }
}