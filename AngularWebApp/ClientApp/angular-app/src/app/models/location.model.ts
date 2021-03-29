import { City } from "./city.model";

export class Location {
  id: number = 0;
  locationName: string = '';
  city: City = new City();
}
