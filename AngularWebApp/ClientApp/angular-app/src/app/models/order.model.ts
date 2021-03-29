import { Stop } from "./stop.model";

export class Order {
  id: number = 0;
  orderNumber: number = 0;
  legNumber: number = 0;
  stops: Stop[] = [];
}
