import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Manager } from '../manager';
import { StoreService } from '../store.service';
import { Branch } from '../branch';
import { LoginServiceService } from '../login-service.service';
import { Router, RouterLink, RouterPreloader } from '@angular/router';
import { User } from 'user';
import { IcuPlaceholder } from '@angular/compiler/src/i18n/i18n_ast';
import { UserServiceService } from '../user-service.service';


@Component({
  selector: 'app-store-sign-up',
  templateUrl: './store-sign-up.component.html',
  styleUrls: ['./store-sign-up.component.scss']
})
export class StoreSignUpComponent implements OnInit {
  userAnswer:string="";
  manager: Manager={managerId:"",firstName:"",lastName:"",mail:"",phone:"",password:"",userName:""};
  m:Manager|undefined;
  u:User={userId:"",firstName:"",lastName:"",mail:"",phone:"",password:""};
  constructor(private loginServiceService:LoginServiceService,private router:Router,private user:UserServiceService) {
   
   }
  ngOnInit(): void {
  }
 

  login(_id :string,_firstName:string,_lastName:string,_mail:string,_phone:string,_userName:string,_password:string){
    debugger;
    if(localStorage.getItem("user")=="store")
   { this.manager.managerId=_id;
    this.manager.firstName=_firstName;
    this.manager.lastName=_lastName;
    this.manager.mail=_mail;
    this.manager.phone=_phone;
    this.manager.userName=_userName;
    this.manager.password=_password;
     return this.loginServiceService.login(this.manager)
     .subscribe((response:any)=> this.saveManager(response));
     
  }
 else  
 { this.u.userId=_id;
    this.u.firstName=_firstName;
    this.u.lastName=_lastName;
    this.u.mail=_mail;
    this.u.password=_mail;
    this.u.phone=_phone;
    return this.user.SignUp(this.u).subscribe(response=>{if(response==true)
    this.router.navigateByUrl("/filterProof");
  else{
    this.userAnswer=" אין אפשרות להרשם כרגע"
  }})
 }
}
  saveManager(response:boolean){
    if (response==true)
    {
      localStorage.setItem("currentManager", JSON.stringify(this.manager));
    
    this.router.navigateByUrl("/setting");
  }
    else console.log("the sign up didn't succeed");
  }
}
