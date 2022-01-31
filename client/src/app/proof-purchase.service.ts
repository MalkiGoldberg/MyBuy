import { Injectable } from '@angular/core';
import { ProofPurchase } from 'src/app/proofPurchase';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { FilterProof } from './filterProof';
import { disableDebugTools } from '@angular/platform-browser';
@Injectable({
  providedIn: 'root'
})
export class ProofPurchaseService {

  constructor(private http:HttpClient) { }
  idAction:string|undefined;


 
 getProofPruchases(filter:any): Observable<ProofPurchase[]> {
   debugger;
 
  const params=new HttpParams({
    //chainStore dont in dal
    fromObject:{
      idUser:filter.idUser,
      kindOfPayment:filter.kindOfPayment,
      action:filter.action,
      category:filter.category,
      chainStore:filter.chainStore,
      branch:filter.branch,
      beginDate:filter.beginDate,
      endDate:filter.endDate,
      recycling:filter.recycling
    }
  })
      return this.http.get<ProofPurchase[]>("https://localhost:44391/api/ProofPurchase/GetProofPruchases",{params:params})   
  }
  GetNumberOfProofPruchase(idUser:string,idAction:any):Observable<number>{
debugger;
    const params=new HttpParams({fromObject:{idUser:idUser,idAction:idAction}})
return this.http.get<number>("https://localhost:44391/api/ProofPurchase/GetNumberOfProofPruchase",{params:params})   
  }
}
