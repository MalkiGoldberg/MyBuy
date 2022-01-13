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
i1:any="";
i2:any=1;
i3:any=2;
i4:any=1;
i7:any='02/02/2000';
i8:any='02/02/2000';
i9:any=true;
i5:any=1;
i6:any=1;
  constructor(private http:HttpClient) { }
  idAction:string|undefined;


 //post 
// א"א לאתחל את האוביקט
 getProofPruchases(filter:any): Observable<ProofPurchase[]> {
   debugger;
   this.i1=filter.idUser;
this.i2=filter.kindOfPayment;
this.i3=filter.action;
this.i4=filter.category;
this.i5=filter.chainStore;
this.i6=filter.branch;
   this.i7=filter.beginDate;
   this.i8=filter.endDate;
   this.i9=filter.recycling;
  const params=new HttpParams({
    
    fromObject:{
      idUser:"212124044",
      kindOfPayment:'1',
      action:'1',
      category:'1',
      chainStore:'1',
      branch:'1',
      beginDate:'02/02/2000',
      endDate:'02/02/2000',
      recycling:'true'
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
