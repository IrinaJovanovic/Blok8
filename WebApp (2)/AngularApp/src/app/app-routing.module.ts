import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { TicketPricesComponent } from './ticket-prices/ticket-prices.component';
import { BusNetworksLinesComponent } from './bus-networks-lines/bus-networks-lines.component';

const routes: Routes = [ {
    path: "",
    component: HomeComponent
  },
  {
    path: "schedule",
    component: ScheduleComponent
  },
  {
    path: "ticket-prices",
    component: TicketPricesComponent
  },
  {
    path: "bus-networks-lines",
    component: BusNetworksLinesComponent
  },];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
