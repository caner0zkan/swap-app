import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  param: any;
  items: any;
  loggedInUser: any;
  selectedProduct: any;
  selectedValue = 0;

  constructor(private activatedRoute: ActivatedRoute, private http: HttpClient) {
    http.get("http://localhost:18697/api/users/GetLoggedIn")
    .subscribe(response=> {
      this.loggedInUser = response;
      console.log(response);
    })
  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(p => {
      this.param = p["id"];
      this.http.get("http://localhost:18697/api/products/"+this.param)
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
    });
  }

  selectChangeHandler(event:any){
    this.selectedValue = event.target.value;
    console.log(this.selectedValue);
  }

  Bid(){
    var a:any=null;
    this.http.get("http://localhost:18697/api/products/"+this.selectedValue)
    .subscribe(response=> {
      this.selectedProduct = response;
      console.log(this.selectedProduct.productID);
    })

    /*this.selectedProduct.productID = this.param;

    this.http.put("http://localhost:18697/api/products",this.selectedProduct)
    .subscribe(response => {
      console.log(response);
    })*/
  }

  createComment(inputComment:HTMLInputElement){
    const post = {
      name: null,
      text: inputComment.value,
      date: "2022-05-05",
      userID: 2,
      productID: Number(this.param)
    }
    console.log(post);

    this.http.post("http://localhost:18697/api/comments",post)
    .subscribe(response => {
      console.log(response);
    })

  }


}
