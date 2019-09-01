import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminEditStationComponent } from './admin-edit-station.component';

describe('AdminEditStationComponent', () => {
  let component: AdminEditStationComponent;
  let fixture: ComponentFixture<AdminEditStationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminEditStationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminEditStationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
