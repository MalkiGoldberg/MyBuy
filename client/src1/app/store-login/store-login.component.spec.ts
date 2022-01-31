import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StoreSignUpComponent } from './store-login.component';

describe('StoreSignUpComponent', () => {
  let component: StoreSignUpComponent;
  let fixture: ComponentFixture<StoreSignUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StoreSignUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StoreSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
