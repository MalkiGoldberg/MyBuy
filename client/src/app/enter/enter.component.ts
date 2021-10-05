import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-enter',
  templateUrl: './enter.component.html',
  styleUrls: ['./enter.component.scss']
})
export class EnterComponent implements OnInit {
  @Input() kindUser:any;
  constructor() { }

  ngOnInit(): void {
  }

}
