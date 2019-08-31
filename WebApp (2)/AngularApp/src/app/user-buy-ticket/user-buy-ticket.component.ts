import { Component, OnInit } from '@angular/core';
import { BuyTicketService } from './buy-ticket.service';
import { NgxPayPalModule, IPayPalConfig } from 'ngx-paypal';
import { Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';

import { UpdateProfileService } from '../update-profile/update-profile.service';


@Component({
  selector: 'app-user-buy-ticket',
  templateUrl: './user-buy-ticket.component.html',
  styleUrls: ['./user-buy-ticket.component.css']
})
export class UserBuyTicketComponent implements OnInit {

  constructor(public service: BuyTicketService, public profileService: UpdateProfileService,  private route: Router,private fb: FormBuilder) { }

  public payPalConfig?: IPayPalConfig;
  ticketType : string = '';
  lineType: string = 'Urban';
  message : string = '';
  price : string = '';
  types : string[];
  status: string;

  ngOnInit() {
  }

}
