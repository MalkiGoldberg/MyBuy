import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private http:HttpClient) { }
 SignUp(user:any):Observable<Boolean>{
  return  this.http.post<Boolean>("https://localhost:44391/api/User/SignUp",user) ;

 }
}
