import { Component, OnInit } from '@angular/core';
import { StoreService } from '../store.service';
import { Category} from "../category"
import {ChainStore} from "../chainStore"
import { Branch } from '../branch';
import { ActivatedRoute, Params,Router  } from '@angular/router';
@Component({
  selector: 'app-new-store',
  templateUrl: './new-store.component.html',
  styleUrls: ['./new-store.component.scss']
})
export class NewStoreComponent implements OnInit {
arrCategories:Category[];
arrChainStore:ChainStore[];
public branch:Branch={
  branchId:0,
  branchName:"",
  city:"",
  address:"",
  password:"",
  idManager:"",
  idChainStore:0,
  phone:"",
  userName:"",
  Categories:[]
};

 chainStore:number;
categories:number[];
  constructor(private store:StoreService, private router:Router,private route: ActivatedRoute
    ) { }

  ngOnInit(): void {

    this.route.queryParams.subscribe(params => {if (params.branch != undefined) 
      {     debugger; 
        //params  ובתוכה לשלוח את  getBranchId  לקרוא לפונקציה מהסרוויס 
        this.store.GetBranch(params['branch']).subscribe(response=>this.branch=response);

      }
    this.store.GetCategories().subscribe(categories => this.arrCategories=categories) ;
    this.store.GetChainStore().subscribe(chainStore => this.arrChainStore=chainStore) ;
   
    });

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
    //איך מקבלים אוביקט ב local storege
    this.branch.idManager=localStorage.getItem("currentManager");
    
    return this.store.signUpBranch(this.branch)
    .subscribe((response:any)=>this.saveBranch(response)
    );


  }

  equal(pass1:string,pass2:string){
    if(pass1!=pass2)
    console.log("cascsc")
    alert("the password is not currect!");
  }

  saveBranch(response:boolean){
    if (response==true)
    {localStorage.setItem("currentBranch", JSON.stringify(this.branch));
    console.log("yes");
    this.router.navigateByUrl("/setting");
}
    else console.log("the sign up didn't succeed");
  }
}



