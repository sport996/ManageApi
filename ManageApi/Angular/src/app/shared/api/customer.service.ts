import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import Customer from '../models/Customer';

@Injectable()
export default class CustomerService {
  public API = 'http://localhost:8080/api';
  public CUSTOMER_API = `${this.API}/customer`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<Array<Customer>> {
    return this.http.get<Array<Customer>>(this.CUSTOMER_API);
  }

  get(id: string) {
    return this.http.get(`${this.CUSTOMER_API}/${id}`);
  }

  save(customer: Customer): Observable<Customer> {
    let result: Observable<Customer>;
    if (customer.Id) {
      result = this.http.put<Customer>(
        `${this.CUSTOMER_API}/${customer.Id}`,
        customer
      );
    } else {
      result = this.http.post<Customer>(this.CUSTOMER_API, customer);
    }
    return result;
  }

  remove(id: number) {
    return this.http.delete(`${this.CUSTOMER_API}/${id.toString()}`);
  }
}