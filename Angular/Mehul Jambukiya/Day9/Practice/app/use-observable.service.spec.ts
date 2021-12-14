import { TestBed } from '@angular/core/testing';

import { UseObservableService } from './use-observable.service';

describe('UseObservableService', () => {
  let service: UseObservableService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UseObservableService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
