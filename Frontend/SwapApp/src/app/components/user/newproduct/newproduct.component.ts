import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-newproduct',
  templateUrl: './newproduct.component.html',
  styleUrls: ['./newproduct.component.css']
})
export class NewproductComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }



  selectedCategory=1;
  a=0;
  selectChangeHandler(event:any){
    this.selectedCategory = event.target.value;
    this.a = +this.selectedCategory;
  }

  createPost(inputTitle:HTMLInputElement,inputDescription:HTMLInputElement,inputPrice:HTMLInputElement,inputKeywords:HTMLInputElement,inputDate:HTMLInputElement){
      let b=0;
      b = +inputPrice.value;

    const post = {
      Title: inputTitle.value,
      Description: inputDescription.value,
      Image: "Image.jpg",
      Price: b,
      Keywords: inputKeywords.value,
      Date: inputDate.value,
      UserID: 1,
      CategoryID: 1,
      ProductStatusID: 1
    }
    console.log(post);

    this.http.post("http://localhost:18697/api/products",post)
      .subscribe(response => {
        console.log(response);
      })
  }


}
