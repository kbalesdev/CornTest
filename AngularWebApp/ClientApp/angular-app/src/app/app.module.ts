import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { AngularMaterialModule } from '../app/angular-material.module'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoadViewComponent } from './load-view/load-view.component';
import { StopDetailComponent } from './load-view/stop-detail/stop-detail.component';
import { BookingDetailComponent } from './booking-detail/booking-detail.component';
import { WorkBenchComponent } from './work-bench/work-bench.component';
import { ContextComponent } from './work-bench/context/context.component';
import { StrategyComponent } from './work-bench/strategy/strategy.component';
import { HistoryComponent } from './work-bench/history/history.component';
import { NegotiationComponent } from './work-bench/negotiation/negotiation.component';
import { ReservationsComponent } from './work-bench/reservations/reservations.component';
import { DiscoveryGlassComponent } from './discovery-glass/discovery-glass.component';
import { SearchComponent } from './discovery-glass/search/search.component';
import { LoadListComponent } from './discovery-glass/load-list/load-list.component';
import { CarrierBrowserComponent } from './carrier-browser/carrier-browser.component';

@NgModule({
  declarations: [
    AppComponent,
    LoadViewComponent,
    StopDetailComponent,
    BookingDetailComponent,
    WorkBenchComponent,
    ContextComponent,
    StrategyComponent,
    HistoryComponent,
    NegotiationComponent,
    ReservationsComponent,
    DiscoveryGlassComponent,
    SearchComponent,
    LoadListComponent,
    CarrierBrowserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AngularMaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
