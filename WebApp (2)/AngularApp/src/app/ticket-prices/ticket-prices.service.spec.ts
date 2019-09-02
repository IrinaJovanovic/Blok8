import { TestBed } from '@angular/core/testing';

import { TicketPricesService } from './ticket-prices.service';

describe('TicketPricesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TicketPricesService = TestBed.get(TicketPricesService);
    expect(service).toBeTruthy();
  });
});
