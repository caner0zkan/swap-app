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
  x=0;
  selectChangeHandler(event:any){
    this.selectedCategory = event.target.value;
    this.x = +this.selectedCategory;
  }

  createPost(inputTitle:HTMLInputElement,inputDescription:HTMLInputElement,inputPrice:HTMLInputElement,inputKeywords:HTMLInputElement){
      let y=0;
      y = +inputPrice.value;

    const post = {
      Title: inputTitle.value,
      Comment: inputDescription.value,
      StartingPrice: y,
      Winner:1,
      Date: null,
      AdminID:1,
      CategoryID: this.x,
      AuctionStatusID: 1
    }
    console.log(post);

    this.http.post("http://localhost:58426/api/auctions",post)
      .subscribe(response => {
        console.log(response);
      })
  }


}
