import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Order } from "../models/order.model";
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  readonly baseUrl = 'http://localhost:49384/api/order';

  constructor(private http: HttpClient) {
  }

  getOrderById(id: number): Observable<Order> {
    return this.http.get<Order>(`${this.baseUrl}/getById/${id}`);
  }
}
