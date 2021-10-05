import { Component, Input, OnInit } from '@angular/core';
import { Branch } from '../branch';
import { StoreService } from '../store.service';

@Component({
  selector: 'app-new-branch',
  templateUrl: './new-branch.component.html',
  styleUrls: ['./new-branch.component.scss']
})
export class NewBranchComponent implements OnInit {
@Input() branch:any;
  constructor(private storeService:StoreService) { }

  ngOnInit(): void {
    
  }
  addBranch(branchName:string,address:string,phone:string){
this.branch.branchName=branchName;
this.branch.address=address;
this.branch.phone=phone;
debugger
this.storeService.addBranch(this.branch).subscribe(response=>console.log(response));
  }
}
