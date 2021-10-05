import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Manager } from '../manager';
import { StoreService } from '../store.service';
import { Branch } from '../branch';
import { LoginServiceService } from '../login-service.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-store-sign-up',
  templateUrl: './store-sign-up.component.html',
  styleUrls: ['./store-sign-up.component.scss']
})
export class StoreSignUpComponent implements OnInit {

  manager: Manager={managerId:"",firstName:"",lastName:"",mail:"",phone:""};
  m:Manager|undefined;

  constructor(private loginServiceService:LoginServiceService) {
   
   }
  ngOnInit(): void {
  }
 
  
  login(_id :string,_firstName:string,_lastName:string,_mail:string,_phone:string){
    this.manager.managerId=_id;
    this.manager.firstName=_firstName;
    this.manager.lastName=_lastName;
    this.manager.mail=_mail;
    this.manager.phone=_phone;
     return this.loginServiceService.login(this.manager)
     .subscribe((response:any)=> this.saveManager(response));
  }
  saveManager(response:boolean){
    if (response==true)
    {localStorage.setItem("currentManager", JSON.stringify(this.manager));
    console.log("yes");
    
}
    else console.log("the sign up didn't succeed");
  }
}
