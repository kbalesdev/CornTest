import { StopTypes } from "./enums/stop-types.model";

export class Stop {
  id: number = 0;
  stopSequence: number = 0;
  stopTypes: StopTypes = StopTypes.Unknown;
  earliestAppointment: Date = new Date();
  latestAppointment: Date = new Date();
  arrivalTime: Date = new Date();
  departureTime: Date = new Date();
  location: Location = new Location();
}
