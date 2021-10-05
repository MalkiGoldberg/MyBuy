import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ErrorServiceService {
arr:string[]=[];
  constructor() { }
  addMessage(message:string){
this.arr.push(message);
  }
}
