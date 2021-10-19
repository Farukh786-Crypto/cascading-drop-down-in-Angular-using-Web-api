import { Component, OnInit } from '@angular/core';
import { CcDropdownService } from '../cc-dropdown.service';
import { FormControl, FormGroup, Validators } from '@angular/forms'

@Component({
  selector: 'app-cascading-dropdown',
  templateUrl: './cascading-dropdown.component.html',
  styleUrls: ['./cascading-dropdown.component.css']
})
export class CascadingDropdownComponent implements OnInit {

  countryList: any;
  stateList: any;
  dropdownForm: any;
  constructor(private dropdownService: CcDropdownService) {
      this.dropdownForm=new FormGroup({
          country:new FormControl(''),
          state:new FormControl('')
      });
  }

  ngOnInit(): void {
    this.getAllCountryData() // load when application start
  }
  getAllCountryData() {
    var obervable = this.dropdownService.getAllCountry();
    obervable.subscribe(
      countryList => {
        this.countryList = countryList; // this data show on table
      });
  }
  // according to country select it call appropriate stateId
  GetstateById(event:any){
      console.log(event); // go browser Event -> target.Value here country id present
      var obervable= this.dropdownService.getStateByCountry(event.target.value);
      obervable.subscribe(stateList=>{
          this.stateList=stateList;
      });
  }
  Savedata(data:any)
  {
    console.log(data);
  }

}
