import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CcDropdownService {

  constructor(private http:HttpClient) { }

  getAllCountry()
  {
    return this.http.get("https://localhost:44310/api/CasCadingDDL/GetAllCountry");
  }

  getStateByCountry(countryId:number)
  {
    return this.http.get("https://localhost:44310/api/CasCadingDDL/GetStateById/"+countryId);
  }

}
