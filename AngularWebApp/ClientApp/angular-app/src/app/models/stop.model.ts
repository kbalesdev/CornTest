import { StopType } from "./stop-type.model";
import { Location } from "./location.model"

export class Stop {
  id: number = 0;
  stopSequence: number = 0;
  stopType: StopType = new StopType();
  earliestAppointment: Date = new Date();
  latestAppointment: Date = new Date();
  arrivalTime: Date = new Date();
  departureTime: Date = new Date();
  location: Location = new Location();
}
