import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { StoreLoginComponent } from './store-login/store-login.component';
import { ProofPurchaseComponent } from './proof-purchase/proof-purchase.component';
import { HomeComponent } from './home/home.component';
import { StoreSignUpComponent } from './store-sign-up/store-sign-up.component';
import { FormsModule } from '@angular/forms';
import { NewBranchComponent } from './new-branch/new-branch.component';
import { FilterProofComponent } from './filter-proof/filter-proof.component';
import { DefinitionsComponent } from './definitions/definitions.component';
//import {MatFormFieldModule,MatInputModule,MatCardModule, MatButtonModule } from '@angular/material';
import { NewStoreComponent } from './new-store/new-store.component';
import { SingleProofComponent } from './single-proof/single-proof.component';
import { PasswordManagerComponent } from './password-manager/password-manager.component';
import { SettingComponent } from './setting/setting.component';
import { EgComponent } from './eg/eg.component';
//import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
//import { FlexLayoutModule } from '@angular/flex-layout';
@NgModule({
  declarations: [
  
      // MatFormFieldModule,
      // MatInputModule,
      // MatCardModule,
      // MatButtonModule,
    AppComponent,
 
    StoreLoginComponent,
 
    ProofPurchaseComponent,
 
    HomeComponent,
 
    StoreSignUpComponent,
 
    NewBranchComponent,
 
    FilterProofComponent,
 
    DefinitionsComponent,
    NewStoreComponent,
    SingleProofComponent,
    PasswordManagerComponent,
    SettingComponent,
    EgComponent
  ],
  imports: [     
    //FlexLayoutModule,
    //BrowserAnimationsModule,
    HttpClientModule,
    //BrowserModule,
    AppRoutingModule,
    FormsModule,
    NgModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
