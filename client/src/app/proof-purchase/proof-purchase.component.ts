import { Component, Input, OnInit } from '@angular/core';
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
@Input() filter:any;
  constructor(private proofPurchase:ProofPurchaseService) {
    

   }

  ngOnInit(): void {
   /* this.getProofPurchases();*/

  }
  //להעביר את הפונקציה לקומפוננטה filter
  /*
  getProofPurchases(): void {
    this.proofPurchase.getProofPruchases(this.filter)
    .subscribe(proof => this.ProofPruchasesArr =proof);
}*/
}