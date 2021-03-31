import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Order } from "../models/order.model";
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  readonly baseUrl = 'http://localhost:49384/api/order';
  order: Order;

  constructor(private http: HttpClient) {
    this.order = new Order();
  }

  getOrderById(id: number): Observable<Order> {
    let test = this.http.get<Order>(`${this.baseUrl}/getById/${id}`);
    console.log(test);
    return test;

    //this.http.get(`${this.baseUrl}/getById/${id}`)
    //  .toPromise()
    //  .then(res => {
    //    console.log(res);
    //    this.order = res as Order;
    //    console.log(this.order);
    //  });
  }
}
