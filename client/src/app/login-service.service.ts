import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { identifierModuleUrl } from '@angular/compiler';
import { ValueConverter } from '@angular/compiler/src/render3/view/template';
import { Injectable } from '@angular/core';
import { Manager } from './manager';
import { Observable, of } from 'rxjs';

 var id:string;
 var manager:Manager;
@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {
  constructor(private http:HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };


public login(manager:Manager):Observable<Manager> {
  return this.http.post<Manager>("https://localhost:44391/api/Manager/Login",manager);
}
loginUser(username:string,password:string):Observable<Boolean>{
    
  const params=new HttpParams({
    fromObject:{
      username:username,
      password:password
    }
  })
  return this.http.get<Boolean>("https://localhost:44391/api/User/Login",{params:params})
}
}