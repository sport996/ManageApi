import { Component, OnInit } from '@angular/core';
import CustomerService from '../shared/api/customer.service';
import Customer from "../shared/models/Customer";

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  customers: Array<Customer>;

  constructor(private customerService: CustomerService) {}

  ngOnInit() {
    this.customerService.getAll().subscribe(data => {
      this.customers = data;
    });
  }
}