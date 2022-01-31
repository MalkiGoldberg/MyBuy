import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Branch } from './branch';
import { Category } from './category';
import { ChainStore } from './chainStore';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  constructor(private http:HttpClient) { }

  signUp(username:string,password:string):Observable<Branch>{
    const params=new HttpParams({
      fromObject:{
        username:username,
        password:password
      }
    })
    return this.http.get<Branch>("https://localhost:44346/api/Branch/SignUp",{params:params})
  }

  GetCategories():Observable<Category[]>{
    return this.http.get<Category[]>("https://localhost:44346/apic");
  }

  GetChainStore():Observable<ChainStore[]>{
    return this.http.get<ChainStore[]>("https://localhost:44346/api/GetChainStores");
  }

  signUpBranch(branch:Branch):Observable<Branch> {
    return this.http.post<Branch>("https://localhost:44346/api/Branch/signUpBranch",branch);
    
  }

  settingBranches():Observable<Branch[]> {
    return this.http.get<Branch[]>("https://localhost:44346/api/signUpBranches");
    
  }

  GetBranch(id:any):Observable<Branch> {debugger;
    
    const params=new HttpParams({
      fromObject:{
        id:id
      }
    })
    return this.http.get<Branch>("https://localhost:44346/api/Branch/GetBranch",{params:params});
    
  }
  

}
