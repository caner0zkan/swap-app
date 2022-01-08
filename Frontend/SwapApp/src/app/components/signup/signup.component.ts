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


  img="../../../assets/img/user/";


  onFileSelected(event:any) {
    if(event.target.files.length > 0)
    {
      this.img+=event.target.files[0].name;
    }
  }


  createPost(inputUsername:HTMLInputElement,inputName:HTMLInputElement,inputSurname:HTMLInputElement,
    inputEmail:HTMLInputElement,inputPassword:HTMLInputElement,inputPhone:HTMLInputElement,inputAdress:HTMLInputElement){
    const post = {
      username: inputUsername.value,
      name : inputName.value,
      surname : inputSurname.value,
      email : inputEmail.value,
      Image: this.img,
      password : inputPassword.value,
      phone: inputPhone.value,
      adress: inputAdress.value
    }
    console.log(post);

    this.http.post("http://localhost:18697/api/users",post)
      .subscribe(response => {
        console.log(response);
      })
  }

}
