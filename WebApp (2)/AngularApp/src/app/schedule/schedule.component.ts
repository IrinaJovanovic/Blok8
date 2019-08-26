import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {

  lineType : string = "";
  lines : string[];
  selectedLine : string = "";
  workDay: string[];
  saturday: string[];
  sunday: string[];

  /* LineForm = this.fb.group({
    LineName: [''],
   
  }); */
 //constructor(private fb: FormBuilder) { }
 constructor() { } 
  ngOnInit() {
  }

  

}
