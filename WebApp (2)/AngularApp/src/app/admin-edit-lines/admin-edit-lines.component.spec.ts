import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminEditLinesComponent } from './admin-edit-lines.component';

describe('AdminEditLinesComponent', () => {
  let component: AdminEditLinesComponent;
  let fixture: ComponentFixture<AdminEditLinesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminEditLinesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminEditLinesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
