import { Component, OnInit } from '@angular/core';
import { OrderService } from "../../services/order.service";

@Component({
  selector: 'app-stop-detail',
  templateUrl: './stop-detail.component.html',
  styleUrls: ['./stop-detail.component.css']
})
export class StopDetailComponent implements OnInit {

  constructor(public orderService: OrderService) { }

  ngOnInit(): void {
  }

}
