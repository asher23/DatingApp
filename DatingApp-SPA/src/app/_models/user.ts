import { Photo } from "./photo";

export interface User {
  id: number;
  age: number;
  username: string;
  knownAs: string;
  created: Date;
  lastActive: Date;
  photoUrl: string;
  city: string;
  country: string;
  interests?: string;
  introduction?: string;
  photos?: Photo[];
  lookingFor?: string;
}
