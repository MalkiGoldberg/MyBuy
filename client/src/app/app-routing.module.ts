import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DefinitionsComponent } from './definitions/definitions.component';
import { FilterProofComponent } from './filter-proof/filter-proof.component';
import { HomeComponent } from './home/home.component';
import { NewBranchComponent } from './new-branch/new-branch.component';
import { ProofPurchaseComponent } from './proof-purchase/proof-purchase.component';
import { StoreLoginComponent } from './store-login/store-login.component';
import { StoreSignUpComponent } from './store-sign-up/store-sign-up.component';
import{EnterComponent}from'./enter/enter.component';
import { NewStoreComponent } from './new-store/new-store.component';
const routes: Routes = [
  {path:"enter",component:EnterComponent},
  {path:"newStore",component:NewStoreComponent},
  {path:"login/:userType",component:StoreLoginComponent},
  {path:"proofPurchase",component:ProofPurchaseComponent},
  {path:"signup/:userType",component:StoreSignUpComponent},
  {path:"home",component:HomeComponent},
{path:"definitions",component:DefinitionsComponent},
{path:"filterProof",component:FilterProofComponent},
  {path:"**",redirectTo:"/home",pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
