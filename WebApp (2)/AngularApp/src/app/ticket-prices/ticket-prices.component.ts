import { Component, OnInit } from '@angular/core';
import { Prices } from './Prices';
import { Discounts } from './Discounts';
import { TicketPricesService } from './ticket-prices.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ticket-prices',
  templateUrl: './ticket-prices.component.html',
  styleUrls: ['./ticket-prices.component.css']
})
export class TicketPricesComponent implements OnInit {

  prices : string[];
  

  constructor(public service: TicketPricesService,private router: Router) { }

  ngOnInit() {
    
    this.getPricelist();  
  }

  public getPricelist()
  {
    this.service.GetPricelist().subscribe((data) => {
      this.prices = data});
  }

  public goHome()
  {
    if(localStorage.role == "AppUser")
    {
      this.router.navigate(['/home-user']);
    }
    else
    {
      this.router.navigate(['/']);
    }
  }

  public buyTicket()
  {
    if(localStorage.role == "AppUser")
    {
      this.router.navigate(['/user-buy-ticket']);
    }
    else
    {
      this.router.navigate(['/buying-ticket']);
    }
    
  }

  Navigate()
  {
    if(localStorage.role == "AppUser")
    {
      this.router.navigate(['app-user-home']);
    }
    else
    {
      this.router.navigate(['home']);
    }
    
  }

  

}
