import { mergeNsAndName } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Manager } from '../manager';
import {LoginServiceService} from '../login-service.service'
import { Router } from '@angular/router';

@Component({
  selector: 'app-store-sign-up',
  templateUrl: './store-sign-up.component.html',
  styleUrls: ['./store-sign-up.component.scss']
})
export class StoreSignUpComponent implements OnInit {
 
  manager: Manager={managerId:"",firstName:"",lastName:"",mail:"",phone:""};
  response:boolean;

  constructor(private loginServiceService:LoginServiceService,private router:Router) {
   
   }
  ngOnInit(): void {
  }
 
  
  login(_id :string,_firstName:string,_lastName:string,_mail:string){
    this.manager.managerId=_id;
    this.manager.firstName=_firstName;
    this.manager.lastName=_lastName;
    this.manager.mail=_mail;
   
     return this.loginServiceService.login(this.manager)
     .subscribe((response:any)=>{this.saveManager(response);
      if(response==true)
      this.router.navigateByUrl("/setting")});

  }
  saveManager(response:boolean){
    if (response==true)
    {localStorage.setItem("currentManager", JSON.stringify(this.manager));
    console.log("yes");
}
    else console.log("the sign up didn't succeed");
    this.response=response;
  }
  
}
