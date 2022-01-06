import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private http: HttpClient,private router: Router,private route: ActivatedRoute) { }

  ngOnInit(): void {
  }

  items: any;
  error="";

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
        if(this.items != null){
          this.router.navigate([`../user/${this.items.id}`], { relativeTo: this.route });
        }
      })

      if(this.items == null){
        this.error = "Girdiğiniz bilgiler hatalıdır. Lütfen kontrol edip, tekrar deneyiniz.";
      }

  }

}
