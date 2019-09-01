import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminEditPriceListComponent } from './admin-edit-price-list.component';

describe('AdminEditPriceListComponent', () => {
  let component: AdminEditPriceListComponent;
  let fixture: ComponentFixture<AdminEditPriceListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminEditPriceListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminEditPriceListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
