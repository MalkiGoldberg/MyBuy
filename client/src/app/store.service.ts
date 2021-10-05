import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Branch } from './branch';
import { Category } from './category';
import { ChainStore } from './chainStore';
import { Payment } from './payment';
import { Action } from './action';
@Injectable({
  providedIn: 'root'
})
export class StoreService {

  constructor(private http:HttpClient) { }

  login(userName:string,password:string):Observable<Branch>{
   const params=new HttpParams({
  fromObject:{
    userName:userName,
    password:password
  }
})
return this.http.get<Branch>("https://localhost:44391/api/Branch/SignUp",{params:params})

  }

  addBranch(Branch:Branch):Observable<Branch>{
 debugger
  return  this.http.post<Branch>("https://localhost:44391/api/Branch/AddBranch",Branch) ;
     
  }

  GetCategories():Observable<Category[]>
  {
    return  this.http.get<Category[]>("https://localhost:44391/api/GetCategories") ;
  }
  GetBranches():Observable<Branch[]>
  {
    return  this.http.get<Branch[]>("https://localhost:44391/api/Branch/GetBranches") ;
  }
  GetChainStores():Observable<ChainStore[]>
  {
    
    return  this.http.get<ChainStore[]>("https://localhost:44391/api/GetChainStores") ;
  }
  GetPayments():Observable<Payment[]>{
return this.http.get<Payment[]>("https://localhost:44391/api/Payment/GetPayments")
  }
  GetActions():Observable<Action[]>{
    return this.http.get<Action[]>("https://localhost:44391/api/Action/GetActions")
      }
 
      signUp(username:string,password:string):Observable<Branch>{
        const params=new HttpParams({
          fromObject:{
            username:username,
            password:password
          }
        })
        return this.http.get<Branch>("https://localhost:44391/api/Branch/SignUp",{params:params})
      }
      signUpBranch(branch:Branch):Observable<Branch> {
        return this.http.post<Branch>("https://localhost:44391/api/Branch/signUpBranch",branch);
        
      }
}
