import { Component, OnInit } from '@angular/core';
import { StoreService } from '../store.service';
import { Branch } from '../branch';
@Component({
  selector: 'app-setting',
  templateUrl: './setting.component.html',
  styleUrls: ['./setting.component.scss']
})
export class SettingComponent implements OnInit {
  public arrBranch:Branch[];
  arrBranchManager:Branch[];
  arr:Branch[];
  idManager=localStorage.getItem("currentManager");

  constructor(private store:StoreService) { }
  
  full():Branch[]{
    this.arrBranch.forEach(element => {
      if(element.idManager==this.idManager)
      this.arr.push(element);
    })
    return this.arr;

  }
  
  removeBranch(branch){

  }


  ngOnInit(): void {
    
    this.store.settingBranches().subscribe(branches => this.arrBranch=branches) ;
   
    // this.arrBranchManager=this.full();
  }


}