import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  items: any;

  createPost(inputUsername:HTMLInputElement,inputPassword:HTMLInputElement){
    const post = {
      username: inputUsername.value,
      password : inputPassword.value
    }
    console.log(post);

    this.http.post("http://localhost:18697/api/login",post)
      .subscribe(response => {
        this.items = response;
        console.log(response);
      })
  }

}
