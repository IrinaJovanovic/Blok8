import { TestBed } from '@angular/core/testing';

import { AdminEditPriceListService } from './admin-edit-price-list.service';

describe('AdminPriceListService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminEditPriceListService = TestBed.get(AdminEditPriceListService);
    expect(service).toBeTruthy();
  });
});
