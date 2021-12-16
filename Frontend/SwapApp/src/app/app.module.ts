import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {RouterModule, Routes} from '@angular/router';
import {HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { SignupComponent } from './components/signup/signup.component';
import { ProductsComponent } from './components/products/products.component';
import { LoginComponent } from './components/login/login.component';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { UserComponent } from './components/user/user.component';
import { NewproductComponent } from './components/user/newproduct/newproduct.component';
import { StatusproductComponent } from './components/user/statusproduct/statusproduct.component';
import { UpdateproductComponent } from './components/user/updateproduct/updateproduct.component';


const appRoutes: Routes= [
  {path: "", component: HomepageComponent}, //localhost:4200
  {path: "home", component: HomepageComponent}, //localhost:4200/homepage
  {path: "signup", component: SignupComponent}, //localhost:4200/signup
  {path: "login", component: LoginComponent}, //localhost:4200/login
  {path: "products", component: ProductsComponent}, //localhost:4200/products
  {path: "user/:id", component: UserComponent}, //localhost:4200/user/id
  {path: "user/:id/newproduct", component: NewproductComponent}, //localhost:4200/user/newproduct
  {path: "user/:id/statusproduct", component: StatusproductComponent}, //localhost:4200/user/statusproduct
  {path: "user/:id/updateproduct", component: UpdateproductComponent}, //localhost:4200/user/updateproduct

  {path: "**", component: NotfoundComponent} //notfound page
];


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    HomepageComponent,
    SignupComponent,
    ProductsComponent,
    LoginComponent,
    NotfoundComponent,
    UserComponent,
    NewproductComponent,
    StatusproductComponent,
    UpdateproductComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
