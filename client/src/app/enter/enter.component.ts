import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-enter',
  templateUrl: './enter.component.html',
  styleUrls: ['./enter.component.scss']
})
export class EnterComponent implements OnInit {
 
  kindUser:string="";
  constructor(private route:ActivatedRoute,private router:Router) { }

  ngOnInit(): void {debugger;
    this.route.queryParams.subscribe(p=>{if(p.string!=undefined)
   this.kindUser=p["string"]
  })

  }
  checkUser(enterType:string){
    if(this.kindUser=="store"&&enterType=="signUp")
    this.router.navigateByUrl("/signup/user");
    else if(this.kindUser=="store"&&enterType=="signIn")
    this.router.navigateByUrl("/login/store");
    // else if(this.kindUser=="customer"&&enterType=="signIn")
    
  }

}
