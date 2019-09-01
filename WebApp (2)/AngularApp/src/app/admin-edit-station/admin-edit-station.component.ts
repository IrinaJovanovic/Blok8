import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { AdminEditStationService } from './admin-edit-station.service';
import { MarkerInfo } from '../bus-networks-lines/marker-info.model';
import { GeoLocation } from '../bus-networks-lines/geolocation';
import { Polyline } from '../bus-networks-lines/polyliner';

@Component({
  selector: 'app-admin-edit-station',
  templateUrl: './admin-edit-station.component.html',
  styleUrls: ['./admin-edit-station.component.css']
})
export class AdminEditStationComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
