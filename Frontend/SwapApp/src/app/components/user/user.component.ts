import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private activatedRoute: ActivatedRoute, private http: HttpClient) { }

  param: any;
  items: any;
  products: any;
  ngOnInit() {
    this.activatedRoute.params.subscribe(p => {
      this.param = p["id"];
      this.http.get("http://localhost:18697/api/users/"+this.param)
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
    });
  }

  deleteItem(id:number){
    this.http.delete("http://localhost:18697/api/products/"+id)
      .subscribe(response => {
        console.log(response);
    })
    window.location.reload();
  }

  public updateItem(id:number){
    return id;
  }

  AcceptBid(id:number){
    this.http.delete("http://localhost:18697/api/products/AcceptBid/"+id)
    .subscribe(response => {
      console.log(response);
  })
    console.log("method works!")
  }

  RejectBid(id:number){
    this.http.get("http://localhost:18697/api/products/"+id)
    .subscribe(response=> {
      this.products = response;
    })

    this.products.fid = null;
    this.products.ftittle = null;
    console.log(this.products);

    this.http.put("http://localhost:18697/api/products",this.products)
    .subscribe(response => {
      console.log(response);
    })
    window.location.reload();
  }



}
