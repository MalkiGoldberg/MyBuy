import { Component, OnInit } from '@angular/core';
import { Manager } from '../manager';
import { Branch } from '../branch';
import { Observable } from 'rxjs';

import { StoreService} from  '../store.service'
import { Router, NavigationExtras } from '@angular/router';
import { Category } from '../category';

@Component({
selector: 'app-store-login',
templateUrl: './store-login.component.html',
styleUrls: ['./store-login.component.scss']
})

export class StoreLoginComponent implements OnInit {

  constructor(private store:StoreService,private router:Router) { }

  ngOnInit(): void {
  }
  signUp(username:string,password:string){
    this.store.signUp(username,password).subscribe(Branch =>{ this.saveBranch(Branch);
      this.router. navigate(["new-store"])
    }
     
      ) 
}

saveBranch(branch:Branch){

if(branch.branchId!==0)
localStorage.setItem("currentBranch",JSON.stringify(branch));

else console.log("the branch is not exist")
}
}




