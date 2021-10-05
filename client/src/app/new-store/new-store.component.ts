import { Component, OnInit } from '@angular/core';
import { StoreService } from '../store.service';
import { Category} from "../category"
import {ChainStore} from "../chainStore"
import { Branch } from '../branch';
@Component({
  selector: 'app-new-store',
  templateUrl: './new-store.component.html',
  styleUrls: ['./new-store.component.scss']
})
export class NewStoreComponent implements OnInit {
arrCategories:Category[]=[];
arrChainStore:ChainStore[]=[];
public branch:Branch={branchId:1,
  branchName:"",
  city:"",
  address:"",
  password:"",
  idManager:"",
  idChainStore:1,
  phone:"",
  userName:"",
Categories:[]};
t=localStorage.getItem("currentManager");
chainStore:number=1;
categories:number[]=[];
i:number[]=[1,2,3];
  constructor(private store:StoreService) { }

  ngOnInit() {
    
    this.store.GetCategories().subscribe(categories => this.arrCategories=categories) ;
  
    
    this.store.GetChainStores().subscribe(chainStore =>this.arrChainStore=chainStore
   );
  }
click(){
  debugger;
}
  signUpBranch(userName:string,password:string,nameStore:string,phone:string,address:string,city:string){
    this.branch.userName=userName;
    this.branch.password=password;
    this.branch.branchName=nameStore;
    this.branch.phone=phone;
    this.branch.address=address;
    this.branch.city=city;
    this.branch.idChainStore=this.chainStore;
    this.branch.Categories=this.categories;
 // this.branch.idManager=this.t;
    return this.store.signUpBranch(this.branch)
    .subscribe((response:any)=>this.saveBranch(response));

  }
  saveBranch(response:boolean){
    if (response==true)
    {localStorage.setItem("currentBranch", JSON.stringify(this.branch));
    console.log("yes");
}
    else console.log("the sign up didn't succeed");
  }
}


