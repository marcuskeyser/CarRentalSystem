import { Component, OnInit } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { Schedule } from '../../view-models/schedule';
import { Schedules } from '../mock-data';

@Component({
  selector: 'app-rental-schedule',
  templateUrl: './rental-schedule.component.html',
  styleUrls: ['./rental-schedule.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0', display: 'none'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class RentalScheduleComponent implements OnInit {

  selectedSchedule: Schedule;
  displayedColumns: string[] = ['name', 'from', 'to', 'make', 'model', 'type'];
  columnsToDisplay: string[] = this.displayedColumns.slice();
  dataSource = Schedules;
  expandedElement: Schedule;

  /*
  addColumn() {
    const randomColumn = Math.floor(Math.random() * this.displayedColumns.length);
    this.columnsToDisplay.push(this.displayedColumns[randomColumn]);
  }

  removeColumn() {
    if (this.columnsToDisplay.length) {
      this.columnsToDisplay.pop();
    }
  }

  shuffle() {
    let currentIndex = this.columnsToDisplay.length;
    while (0 !== currentIndex) {
      const randomIndex = Math.floor(Math.random() * currentIndex);
      currentIndex -= 1;

      // Swap
      const temp = this.columnsToDisplay[currentIndex];
      this.columnsToDisplay[currentIndex] = this.columnsToDisplay[randomIndex];
      this.columnsToDisplay[randomIndex] = temp;
    }
  }
  */
  constructor() { }

  ngOnInit() {
  }

  onSelect(schedule: Schedule): void {
    this.selectedSchedule = schedule;
  }
}
