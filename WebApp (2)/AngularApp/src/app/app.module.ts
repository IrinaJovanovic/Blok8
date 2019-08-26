import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { TicketPricesComponent } from './ticket-prices/ticket-prices.component';
import { BusNetworksLinesComponent } from './bus-networks-lines/bus-networks-lines.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ScheduleComponent,
    TicketPricesComponent,
    BusNetworksLinesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
