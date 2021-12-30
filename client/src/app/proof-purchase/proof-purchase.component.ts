import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProofPurchase } from 'src/app/proofPurchase';
import { FilterProof } from '../filterProof';
import { ProofPurchaseService } from '../proof-purchase.service';

@Component({
  selector: 'app-proof-purchase',
  templateUrl: './proof-purchase.component.html',
  styleUrls: ['./proof-purchase.component.scss']
})
export class ProofPurchaseComponent implements OnInit {
 ProofPruchasesArr: ProofPurchase[] = [];
 filter:FilterProof={idUser:"212124044",kindOfPayment:1,action:1,category:1,branch:1,chainStore:1,beginDate:new Date(2000,1,2),endDate:new Date(2000,1,2),recycling:true};

  constructor(private proofPurchase:ProofPurchaseService,private route:ActivatedRoute) {
    

   }

  ngOnInit(): void {
    
debugger; 
this.route.queryParams.subscribe(p=>{if(p.FilterProof!=undefined)
  debugger;
 this.filter=p["FilterProof"]});
console.log(this.filter.action)
 
  }

  
}
  