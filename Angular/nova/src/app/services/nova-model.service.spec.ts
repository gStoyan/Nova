import { TestBed } from '@angular/core/testing';

import { NovaModelService } from './nova-model.service';

describe('NovaModelService', () => {
  let service: NovaModelService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(NovaModelService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
