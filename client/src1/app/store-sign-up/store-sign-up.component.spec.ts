import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StoreSignUpComponent } from './store-sign-up.component';

describe('StoreLoginComponent', () => {
  let component: StoreSignUpComponent;
  let fixture: ComponentFixture<StoreSignUpComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StoreSignUpComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StoreSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
