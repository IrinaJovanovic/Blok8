import { Component, OnInit } from '@angular/core';
import { MarkerInfo } from './marker-info.model';
import { GeoLocation } from './geolocation';
import { Polyline } from './polyliner';
import { BusNetworksLinesService } from './bus-networks-lines.service';
import { LineModel } from './lineModel';
import { FormGroup, FormBuilder, FormArray, FormControl } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-bus-networks-lines',
  templateUrl: './bus-networks-lines.component.html',
  styleUrls: ['./bus-networks-lines.component.css'],
  styles: ['agm-map {height: 500px; width: 1000px;}']
})
export class BusNetworksLinesComponent implements OnInit {
  markerInfo: MarkerInfo;
  selLine: Polyline;
  stati: any = [];
  showLines: any =[];
  allLines: any = [];
  showStations  = false;
  myGroup: FormGroup;
  show: boolean = false;
  iconPath : any = { url:"assets/homebus.jpg", scaledSize: {width: 35, height: 35}}
  constructor(public service : BusNetworksLinesService, private formBuilder: FormBuilder, private route: Router) { }

  ngOnInit() {
    this.markerInfo = new MarkerInfo(new GeoLocation(45.242268, 19.842954), 
    "assets/pronadjiLokaciju.jpg",
    "Jugodrvo" , "" , "http://ftn.uns.ac.rs/691618389/fakultet-tehnickih-nauka");
    this.selLine = new Polyline([], 'red', { url:"assets/homebus.jpg", scaledSize: {width: 50, height: 50}});
    this.GetAllLines();
  }

  GetAllStations()
  {
      this.service.GetAllStations().subscribe((data)=>{
         this.stati = data;
         console.log(data);
      });
  }

  GetAllLines()
  {
    this.service.GetAllLines().subscribe((data)=>{
        this.allLines = data;
        console.log(data);

          this.showCheckBoxes();
    });
  }

  


  ShowStationsSelectionChanged()
  {
    if(this.showStations == false)
      {
        this.GetAllStations();
        this.showStations = true;
      }
    else
    {
      this.stati = [];
      this.showStations = false;
    }
  }


  AddLineToShowLines(lNum: any)
  {
    this.allLines.forEach(element => {
      if(element.LineNumber == lNum)
      {
        this.showLines.push(element);
        console.log(element)
      }
      
    });
  }


  showCheckBoxes(){
    console.log("sssss");
    this.myGroup = this.formBuilder.group({
      allLines: new FormArray([]) //new FormArray(formControls)
    });

    this.addCheckBoxes();
    this.show = true;
  }

  private addCheckBoxes(){
    this.allLines.map((o,i)=> {
      const control = new FormControl(false);
      (this.myGroup.controls.allLines as FormArray).push(control);
    });
    console.log("Metoda add checkBoxes");
  }
  
  FieldsChange(event){
    let ln = event.currentTarget.checked;
    console.log(ln);
    console.log(event.currentTarget.value);
    let lNum = event.currentTarget.value;
    if(ln)
    {
      this.AddLineToShowLines(lNum);
      console.log(this.showLines);
    }
    else{
      this.RemoveLineFromShowLines(lNum);
      console.log(this.showLines);
    }
    
  }

  RemoveLineFromShowLines(lNum: string)
  {
    let a : LineModel;
    
    this.showLines.forEach(element => {
      if(element.LineNumber == lNum)
      {
        a = element;
      }
    });
    const index : number = this.showLines.indexOf(a);
    this.showLines.splice(index,1);
  }

  Navigate()
  {
    if(localStorage.role == "AppUser")
    {
      this.route.navigate(['home-user']);
    }
    else
    {
      this.route.navigate(['home']);
    }
    
  }
}
