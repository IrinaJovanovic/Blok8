import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule , FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { TicketPricesComponent } from './ticket-prices/ticket-prices.component';
import { BusNetworksLinesComponent } from './bus-networks-lines/bus-networks-lines.component';
import { RegisterComponent } from './register/register.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { LoginComponent } from './auth/login/login.component';
import { HomeUserComponent } from './home-user/home-user.component';
import { UserBuyTicketComponent } from './user-buy-ticket/user-buy-ticket.component';

import { UpdateProfileComponent } from './update-profile/update-profile.component';
import {UpdateProfileService} from './update-profile/update-profile.service'
import { NgxPayPalModule } from 'ngx-paypal';
import { JwtInterceptor } from './auth/jwt-interceptor';
import { BuyTicketService } from './user-buy-ticket/buy-ticket.service';
import { Component } from '@angular/core';
import { AgmDirectionModule } from 'agm-direction'
import { AgmCoreModule } from '@agm/core';
import {BusNetworksLinesService} from './bus-networks-lines/bus-networks-lines.service';
import { AdminComponent } from './admin/admin.component';
import { AdminEditLinesComponent } from './admin-edit-lines/admin-edit-lines.component';
import { AdminEditStationComponent } from './admin-edit-station/admin-edit-station.component';
import { AdminEditPriceListComponent } from './admin-edit-price-list/admin-edit-price-list.component';
import { AdminEditScheduleComponent } from './admin-edit-schedule/admin-edit-schedule.component';
import { BuyingTicketComponent } from './buying-ticket/buying-ticket.component';
import { CheckInTicketComponent } from './check-in-ticket/check-in-ticket.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ScheduleComponent,
    TicketPricesComponent,
    BusNetworksLinesComponent,
    RegisterComponent,
    LoginComponent,
    HomeUserComponent,
    UserBuyTicketComponent,
    UpdateProfileComponent,
    AdminComponent,
    AdminEditLinesComponent,
    AdminEditStationComponent,
    AdminEditPriceListComponent,
    AdminEditScheduleComponent,
    BuyingTicketComponent,
    CheckInTicketComponent,
    
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    NgxPayPalModule,
    AgmDirectionModule,
    AgmCoreModule.forRoot({apiKey: 'AIzaSyDnihJyw_34z5S1KZXp90pfTGAqhFszNJk'}),
  ],
  providers: [UpdateProfileService,{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true},
    BuyTicketService,{provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true}],
  bootstrap: [AppComponent]
})
export class AppModule { }
