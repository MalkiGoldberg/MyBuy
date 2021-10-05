import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilterProofComponent } from './filter-proof.component';

describe('FilterProofComponent', () => {
  let component: FilterProofComponent;
  let fixture: ComponentFixture<FilterProofComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FilterProofComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FilterProofComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
