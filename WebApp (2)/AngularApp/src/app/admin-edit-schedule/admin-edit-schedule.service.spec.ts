import { TestBed } from '@angular/core/testing';

import { AdminEditScheduleService } from './admin-edit-schedule.service';

describe('AdminEditScheduleService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminEditScheduleService = TestBed.get(AdminEditScheduleService);
    expect(service).toBeTruthy();
  });
});
