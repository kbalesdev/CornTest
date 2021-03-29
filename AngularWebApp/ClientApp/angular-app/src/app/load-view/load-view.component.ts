import { Component, OnInit } from '@angular/core';
import { OrderService } from "../services/order.service";
import { Order } from "../models/order.model";

@Component({
  selector: 'app-load-view',
  templateUrl: './load-view.component.html',
  styleUrls: ['./load-view.component.css']
})
export class LoadViewComponent implements OnInit {

  constructor(public orderService: OrderService) {
  }

  ngOnInit(): void {
    this.orderService.getOrderById(333);
    console.log(this.orderService.order);
  }

}
