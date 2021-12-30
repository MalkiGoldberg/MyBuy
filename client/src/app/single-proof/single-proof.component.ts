import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-single-proof',
  templateUrl: './single-proof.component.html',
  styleUrls: ['./single-proof.component.scss']
})
export class SingleProofComponent implements OnInit {
@Input() item:any;
  constructor() { }

  ngOnInit(): void {
    debugger;
  }

}
