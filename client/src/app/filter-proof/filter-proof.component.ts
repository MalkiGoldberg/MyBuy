import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { StoreService } from '../store.service';
import { Category } from '../category';
import { Branch } from '../branch';
import { ChainStore } from '../chainStore';
import { FilterProof } from '../filterProof';
import { Payment } from '../payment';
import { Action } from '../action';
import { ProofPurchaseService } from '../proof-purchase.service';
import { ProofPurchase } from '../proofPurchase';

@Component({
  selector: 'app-filter-proof',
  templateUrl: './filter-proof.component.html',
  styleUrls: ['./filter-proof.component.scss']
})
export class FilterProofComponent implements OnInit {
  acquittal:number=0;
  arrCategories:Category[]=[];
  arrBranches:Branch[]=[];
  arrChainStores:ChainStore[]=[];
  arrPayments:Payment[]=[];
  arrActions:Action[]=[];
  ProofPruchaseArr:ProofPurchase[]=[];
  public filter:FilterProof= {idUser:"212124044",kindOfPayment:1,action:1,category:1,branch:1,chainStore:1,beginDate:new Date(2000,1,2),endDate:new Date(2000,1,2),recycling:true}
  constructor(private StoreService:StoreService,private ProofPruchaseService:ProofPurchaseService) { }

  ngOnInit(): void {
    this.ProofPruchaseService.GetNumberOfProofPruchase(this.filter.idUser,1).subscribe(response=>this.acquittal=response);
    this.StoreService.GetBranches().subscribe(response=>this.arrBranches=response)
    this.StoreService.GetChainStores().subscribe(response=>this.arrChainStores=response)
    this.StoreService.GetCategories().subscribe(response=>this.arrCategories=response)
    this.StoreService.GetPayments().subscribe(response=>this.arrPayments=response)
    this.StoreService.GetActions().subscribe(response=>this.arrActions=response)
    
  }
  check(){debugger;}
  chooseChainStore(chainId:number){
  this.arrBranches=this.arrBranches.filter(arr=>arr.idChainStore==chainId) ;
 console.log(this.filter.chainStore);
  }
 
}
