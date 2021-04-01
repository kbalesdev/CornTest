import { Component, OnInit } from '@angular/core';
import { OrderService } from "../../services/order.service";
import { Order } from "../../models/order.model";

@Component({
  selector: 'app-stop-detail',
  templateUrl: './stop-detail.component.html',
  styleUrls: ['./stop-detail.component.css']
})
export class StopDetailComponent implements OnInit {

  order: Order;

  constructor(public orderService: OrderService) {
    this.order = new Order();
  }

  ngOnInit(): void {
    this.getOrderById();
  }

  getOrderById(): void {
    this.orderService.getOrderById(333)
      .subscribe(order => {
        this.order = order;
      });
  }

}
