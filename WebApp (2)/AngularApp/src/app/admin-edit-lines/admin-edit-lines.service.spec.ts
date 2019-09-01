import { TestBed } from '@angular/core/testing';

import { AdminEditLinesService } from './admin-edit-lines.service';

describe('AdminEditLinesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminEditLinesService = TestBed.get(AdminEditLinesService);
    expect(service).toBeTruthy();
  });
});
