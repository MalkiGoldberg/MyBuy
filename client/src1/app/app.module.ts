import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { StoreLoginComponent } from './store-login/store-login.component';
import { HomeComponent } from './home/home.component';
import { StoreSignUpComponent } from './store-sign-up/store-sign-up.component';
import {FormsModule} from '@angular/forms';
import { NewStoreComponent } from './new-store/new-store.component';
import { SettingComponent } from './setting/setting.component';

@NgModule({
  declarations: [
    AppComponent,
 
    StoreLoginComponent,
    
 
    HomeComponent,
 
    StoreSignUpComponent,
 
    NewStoreComponent,
 
    SettingComponent,
 

  ],
  imports: [
    FormsModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
