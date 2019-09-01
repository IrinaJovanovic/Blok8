import { TestBed } from '@angular/core/testing';

import { TicketPriceService } from './ticket-prices.service';

describe('TicketPriceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TicketPriceService = TestBed.get(TicketPriceService);
    expect(service).toBeTruthy();
  });
});
