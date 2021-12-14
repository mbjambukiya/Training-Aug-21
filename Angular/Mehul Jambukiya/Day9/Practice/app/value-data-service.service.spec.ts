import { TestBed } from '@angular/core/testing';

import { ValueDataServiceService } from './value-data-service.service';

describe('ValueDataServiceService', () => {
  let service: ValueDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ValueDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
