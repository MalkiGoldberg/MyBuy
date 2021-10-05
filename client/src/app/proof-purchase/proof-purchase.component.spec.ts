import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProofPurchaseComponent } from './proof-purchase.component';

describe('ProofPurchaseComponent', () => {
  let component: ProofPurchaseComponent;
  let fixture: ComponentFixture<ProofPurchaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProofPurchaseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProofPurchaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
