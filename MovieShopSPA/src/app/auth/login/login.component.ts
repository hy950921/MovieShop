import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/shared/models/login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

// two way binding
// one way binding

    userLogin: Login = {
        email: '', password: ''
    };
    constructor() { }

    ngOnInit(): void {
    }
    
    login() {
        console.log('button is clicked');
    }

}
