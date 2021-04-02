import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoadViewComponent } from './load-view/load-view.component';
import { StopDetailComponent } from './load-view/stop-detail/stop-detail.component';
import { BookingDetailComponent } from './booking-detail/booking-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    LoadViewComponent,
    StopDetailComponent,
    BookingDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
