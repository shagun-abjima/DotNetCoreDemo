import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product/product.component';
import { SuggestedProductsComponent } from './suggested-product/suggested-products/suggested-products.component';
import { HomeComponent } from './home/home/home.component';
import { RegisterComponent } from './register/register/register.component';
import { LoginComponent } from './login/login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    SuggestedProductsComponent,
    HomeComponent,
    RegisterComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
