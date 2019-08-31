import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth/auth.service';
import { Route } from '@angular/compiler/src/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home-user',
  templateUrl: './home-user.component.html',
  styleUrls: ['./home-user.component.css']
})
export class HomeUserComponent implements OnInit {

  constructor(private service : AuthService, private router : Router) { }

  ngOnInit() {
  }

  Logout()
  {
    this.service.logout();
    this.router.navigate(['login']);

  }

}
