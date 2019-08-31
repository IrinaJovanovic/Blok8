import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { TicketPricesComponent } from './ticket-prices/ticket-prices.component';
import { BusNetworksLinesComponent } from './bus-networks-lines/bus-networks-lines.component';
import { RegisterComponent } from './register/register.component';
import { LoginGuard } from './auth/login.guard';
import { LoginComponent } from './auth/login/login.component';
import { AuthGuard } from './auth/auth.guard';
import { UserGuard } from './auth/user.guard';
import { HomeUserComponent } from './home-user/home-user.component';
import { UserBuyTicketComponent } from './user-buy-ticket/user-buy-ticket.component';
import { UpdateProfileComponent } from './update-profile/update-profile.component';

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
  },
  {
    path: "register",
    component: RegisterComponent
  },
  { 
    path: "login", 
    component: LoginComponent, 
    canActivate: [LoginGuard]
  },
  { 
    path: "home-user", 
    component: HomeUserComponent, 
    canActivate: [UserGuard]
  },
  { 
    path: "user-buy-ticket", 
    component: UserBuyTicketComponent, 
    canActivate: [UserGuard]
  },
  { 
    path: "update-profile", 
    component: UpdateProfileComponent, 
    canActivate: [UserGuard]
  },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
