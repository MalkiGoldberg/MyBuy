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
import { EnterComponent } from './enter/enter.component';
import { NewStoreComponent } from './new-store/new-store.component';

@NgModule({
  declarations: [
    AppComponent,
 
    StoreLoginComponent,
 
    ProofPurchaseComponent,
 
    HomeComponent,
 
    StoreSignUpComponent,
 
    NewBranchComponent,
 
    FilterProofComponent,
 
    DefinitionsComponent,
 
    EnterComponent,
    NewStoreComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
