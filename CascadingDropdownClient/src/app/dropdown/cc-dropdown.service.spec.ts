import { TestBed } from '@angular/core/testing';

import { CcDropdownService } from './cc-dropdown.service';

describe('CcDropdownService', () => {
  let service: CcDropdownService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CcDropdownService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
