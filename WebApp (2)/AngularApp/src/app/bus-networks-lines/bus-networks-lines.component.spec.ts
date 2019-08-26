import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BusNetworksLinesComponent } from './bus-networks-lines.component';

describe('BusNetworksLinesComponent', () => {
  let component: BusNetworksLinesComponent;
  let fixture: ComponentFixture<BusNetworksLinesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BusNetworksLinesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BusNetworksLinesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
