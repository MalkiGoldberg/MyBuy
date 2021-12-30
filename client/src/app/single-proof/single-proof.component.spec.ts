import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleProofComponent } from './single-proof.component';

describe('SingleProofComponent', () => {
  let component: SingleProofComponent;
  let fixture: ComponentFixture<SingleProofComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleProofComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleProofComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
