import { BrowserModule } from '@angular/platform-browser';
import {  NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DefaultModule } from './layouts/default/default.module';/* 
import {MatGridListModule}  from '@angular/material/grid-list';
import {FormsModule, ReactiveFormsModule} from '@angular/forms'; */

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    DefaultModule,
   /*  MatGridListModule,
    FormsModule,
    ReactiveFormsModule */
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
