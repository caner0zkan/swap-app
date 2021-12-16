import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  createPost(inputName:HTMLInputElement,inputSurname:HTMLInputElement,inputEmail:HTMLInputElement,inputPassword:HTMLInputElement){
    const post = {
      name : inputName.value,
      surname : inputSurname.value,
      email : inputEmail.value,
      password : inputPassword.value
    }
    console.log(post);

    this.http.post("http://localhost:58426/api/users",post)
      .subscribe(response => {
        console.log(response);
      })
  }

}
