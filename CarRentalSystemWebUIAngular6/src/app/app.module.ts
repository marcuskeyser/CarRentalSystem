import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {  MatButtonModule,
          MatCheckboxModule,
          MatCardModule,
          MatProgressSpinnerModule,
          MatMenuModule,
          MatIconModule,
          MatToolbarModule,
          MatFormFieldModule,
          MatInputModule,
          MatSelectModule,
          MatSortModule,
          MatTableModule
        } from '@angular/material';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { RentalScheduleComponent } from './rental/rental-schedule/rental-schedule.component';
import { CustomerComponent } from './customer/customer.component';
import { CarTypeComponent } from './car-type/car-type.component';
import { CarComponent } from './car/car.component';
import { RentalDetailComponent } from './rental/rental-detail/rental-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    RentalScheduleComponent,
    RentalDetailComponent,
    CustomerComponent,
    CarTypeComponent,
    CarComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatCardModule,
    MatProgressSpinnerModule,
    MatMenuModule,
    MatIconModule,
    MatToolbarModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatSortModule,
    MatTableModule  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
