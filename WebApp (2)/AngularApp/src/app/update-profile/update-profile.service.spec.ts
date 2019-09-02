import { TestBed } from '@angular/core/testing';

import { UpdateProfileService } from './update-profile.service';

describe('EditProfileService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UpdateProfileService = TestBed.get(UpdateProfileService);
    expect(service).toBeTruthy();
  });
});
