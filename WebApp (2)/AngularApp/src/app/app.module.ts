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
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    NgxPayPalModule,
  ],
  providers: [UpdateProfileService,{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true},
    BuyTicketService,{provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true}],
  bootstrap: [AppComponent]
})
export class AppModule { }
