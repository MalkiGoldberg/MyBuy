import { mergeNsAndName } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { Branch } from '../branch';
import { LoginServiceService } from '../login-service.service';
import { Manager } from '../manager';
import { StoreService } from '../store.service';
import { UserServiceService } from '../user-service.service';

@Component({
  selector: 'app-store-login',
  templateUrl: './store-login.component.html',
  styleUrls: ['./store-login.component.scss']
})
export class StoreLoginComponent implements OnInit {

  kindUser:string="";
 userAnswer:string=""; 

  constructor(private store: StoreService,private router:Router,private loginService:LoginServiceService, private activatedRoute:ActivatedRoute ,private user:UserServiceService) { }
  
  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(p=>{if(p.string!=undefined)this.kindUser=p["string"]})
  }

  login(userName: string, password: string) 
  {
    this.userAnswer="";

    if(this.kindUser=="store"){
    this.store.login(userName, password).subscribe(branch => {
      if(branch.branchId!=0&&branch!=null)
        {
           localStorage.setItem("currentBranchId", JSON.stringify(branch.branchId));
           this.router.navigateByUrl("/setting");
        }
      else 
          this.store.loginManager(userName, password).subscribe
          (response => {if(response!="error"){localStorage.setItem("currentManagerId",JSON.stringify(response)); this.router.navigateByUrl("/setting");}else this.userAnswer="הלקוח אינו קים במערכת";})
    })
  }
  else{
    this.loginService.loginUser(userName,password).subscribe(response=>{
      if(response==true)
    {
    localStorage.setItem("currentUserId",JSON.stringify(userName));
    localStorage.setItem("currentUserPassword",JSON.stringify(password));
   this.router.navigateByUrl("/filterProof");
  }
  else this.userAnswer="הלקוח אינו קים במערכת";
  });
  
 
}
  
  }
  newUser()
  {
    if(this.kindUser=="store")
   { localStorage.setItem("user","store");
    this.router.navigateByUrl("/signup/store");
  }
  else{
  this.router.navigateByUrl("/signup/customer");
  localStorage.setItem("user","customer"); 
  }
  }
}
