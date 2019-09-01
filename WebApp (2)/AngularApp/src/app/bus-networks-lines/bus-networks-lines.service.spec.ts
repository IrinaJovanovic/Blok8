import { TestBed } from '@angular/core/testing';

import { BusNetworksLinesService } from './bus-networks-lines.service';

describe('BusNetworksLinesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BusNetworksLinesService = TestBed.get(BusNetworksLinesService);
    expect(service).toBeTruthy();
  });
});
