import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-definitions',
  templateUrl: './definitions.component.html',
  styleUrls: ['./definitions.component.scss']
})
export class DefinitionsComponent implements OnInit {
userAnswer:string="";
  constructor() { }

  ngOnInit(): void {
  }
check(password:string){
  if(!(password==localStorage.getItem("currentUserPassword")))
this.userAnswer="הסיסמא שגויה";
}
}
