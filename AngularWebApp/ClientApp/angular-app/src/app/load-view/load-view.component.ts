import { Component, OnInit } from '@angular/core';
import { OrderService } from "../services/order.service";

@Component({
  selector: 'app-load-view',
  templateUrl: './load-view.component.html',
  styleUrls: ['./load-view.component.css']
})
export class LoadViewComponent implements OnInit {

  constructor(public orderService: OrderService) {
  }

  ngOnInit(): void {
  }

}
