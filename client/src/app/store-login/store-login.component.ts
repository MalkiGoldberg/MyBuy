import { mergeNsAndName } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Branch } from '../branch';
import { LoginServiceService } from '../login-service.service';
import { Manager } from '../manager';
import { StoreService } from '../store.service';

@Component({
  selector: 'app-store-login',
  templateUrl: './store-login.component.html',
  styleUrls: ['./store-login.component.scss']
})
export class StoreLoginComponent implements OnInit {

  f:string="";
  constructor(private store: StoreService,private router:Router) { }
  ngOnInit(): void {
  }
  login(userName: string, password: string) {
    this.store.login(userName, password).subscribe(branch => {
     this.saveBranch(branch);
    // input איך שולחים 
    if(branch!=null)
 this.router.navigateByUrl("/filterProof");
    })

  }
  saveBranch(branch: Branch) {
    if (branch.branchId != 0)
      {localStorage.setItem("currentBranch", JSON.stringify(branch));
 }
      else console.log("the branch is not exist");
  }
}
