import { TestBed } from '@angular/core/testing';

import { SmiteApiService } from './smite-api.service';

describe('SmiteApiService', () => {
  let service: SmiteApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SmiteApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
