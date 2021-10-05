import { Injectable } from '@angular/core';
import { ProofPurchase } from 'src/app/proofPurchase';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { FilterProof } from './filterProof';
@Injectable({
  providedIn: 'root'
})
export class ProofPurchaseService {

  constructor(private http:HttpClient) { }
  idAction:string|undefined;


 //post 
// א"א לאתחל את האוביקט
 getProofPruchases(filter:any): Observable<ProofPurchase[]> {
  const params=new HttpParams({
    fromObject:{
      idUser:filter.idUser,
      kindOfPayment:filter.kindOfPayment,
      action:filter.action,
      category:filter.category,
      chainStore:filter.chainStore,
      branch:filter.branch,
      beginDate:filter.startDate,
      endDate:filter.endDate,
      recycling:filter.recycling
    }
  })
      return this.http.get<ProofPurchase[]>("https://localhost:44391/api/ProofPurchase/GetProofPruchases",{params:params})   
  }
  GetNumberOfProofPruchase(idUser:string,idAction:any):Observable<number>{

    const params=new HttpParams({fromObject:{idUser:idUser,idAction:idAction}})
return this.http.get<number>("https://localhost:44391/api/ProofPurchase/GetNumberOfProofPruchase",{params:params})   
  }
}
