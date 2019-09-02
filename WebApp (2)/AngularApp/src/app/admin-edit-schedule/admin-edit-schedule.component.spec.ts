import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminEditScheduleComponent } from './admin-edit-schedule.component';

describe('AdminEditScheduleComponent', () => {
  let component: AdminEditScheduleComponent;
  let fixture: ComponentFixture<AdminEditScheduleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminEditScheduleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminEditScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
