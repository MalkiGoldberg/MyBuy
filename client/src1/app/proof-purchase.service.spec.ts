import { TestBed } from '@angular/core/testing';

import { ProofPurchaseService } from './proof-purchase.service';

describe('ProofPurchaseService', () => {
  let service: ProofPurchaseService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProofPurchaseService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
