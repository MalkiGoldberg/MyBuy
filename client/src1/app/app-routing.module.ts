import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { StoreSignUpComponent } from './store-sign-up/store-sign-up.component';
import { StoreLoginComponent } from './store-login/store-login.component';
import { NewStoreComponent } from './new-store/new-store.component';
import { SettingComponent } from './setting/setting.component';


const routes: Routes = [
  {path:"login",component:StoreLoginComponent},
  {path:"sign up",component:StoreSignUpComponent},
  {path:"home",component:HomeComponent},
  {path:"new-store",component:NewStoreComponent},
  {path:"setting",component:SettingComponent},
  {path:"**",redirectTo:"/home",pathMatch:"full"},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
