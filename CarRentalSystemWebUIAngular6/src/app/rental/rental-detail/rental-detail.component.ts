import { Component, OnInit, Input  } from '@angular/core';
import { Schedule } from '../../view-models/schedule';


@Component({
  selector: 'app-rental-detail',
  templateUrl: './rental-detail.component.html',
  styleUrls: ['./rental-detail.component.css']
})
export class RentalDetailComponent implements OnInit {
  @Input() schedule: Schedule;
  constructor() { }

  ngOnInit() {
  }

}
