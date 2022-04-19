import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-updateproduct',
  templateUrl: './updateproduct.component.html',
  styleUrls: ['./updateproduct.component.css']
})
export class UpdateproductComponent implements OnInit {

  constructor(private activatedRoute: ActivatedRoute, private http: HttpClient) { }

  param: any;
  items: any;
  ngOnInit() {
    this.activatedRoute.params.subscribe(p => {
      this.param = p["id"];
      this.http.get("http://localhost:18697/api/products/"+this.param)
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
    });
  }


  selectedCategory=1;
  a=0;
  img="../../../assets/img/product/";


  selectChangeHandler(event:any){
    this.selectedCategory = event.target.value;
    this.a = +this.selectedCategory;
  }

  onFileSelected(event:any) {
    if(event.target.files.length > 0)
    {
      this.img+=event.target.files[0].name;
    }
  }

  updatePost(inputTitle:HTMLInputElement,inputDescription:HTMLInputElement,inputPrice:HTMLInputElement){
      let b=0;
      b = +inputPrice.value;

    const post = {
      Id: this.param,
      Title: inputTitle.value,
      Description: inputDescription.value,
      Image: this.img,
      Price: b,
      CategoryID: 1,
      ProductStatusID: 1,
      UserID: 2
    }
    console.log(post);

    this.http.put("http://localhost:18697/api/products",post)
      .subscribe(response => {
        console.log(response);
      })
  }

}
