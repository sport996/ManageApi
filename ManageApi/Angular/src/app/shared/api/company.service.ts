import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Company } from '../models/Company';

@Injectable()
export default class CompanyService {
  public API = 'http://localhost:8080/api';
  public COMPANY_API = `${this.API}/company`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<Array<Company>> {
    return this.http.get<Array<Company>>(this.COMPANY_API);
  }

  get(id: string) {
    return this.http.get(`${this.COMPANY_API}/${id}`);
  }

  save(company: Company): Observable<Company> {
    let result: Observable<Company>;
    if (company.Id) {
      result = this.http.put<Company>(
        `${this.COMPANY_API}/${company.Id}`,
        company
      );
    } else {
      result = this.http.post<Company>(this.COMPANY_API, company);
    }
    return result;
  }

  remove(id: number) {
    return this.http.delete(`${this.COMPANY_API}/${id.toString()}`);
  }
}