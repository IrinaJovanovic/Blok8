import { TestBed } from '@angular/core/testing';

import { AdminEditStationService } from './admin-edit-station.service';

describe('AdminStationService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminEditStationService = TestBed.get(AdminEditStationService);
    expect(service).toBeTruthy();
  });
});
