import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Order } from "../models/order.model";

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  readonly baseUrl = 'http://localhost:49384/api/order';
  order: Order;

  constructor(private http: HttpClient) {
    this.order = new Order();
  }

  getOrderById(id: number) {
    this.http.get(`${this.baseUrl}/getById/${id}`)
      .toPromise()
      .then(res => {
        console.log(res);
        this.order = res as Order;
        console.log(this.order);
      });
  }
}
