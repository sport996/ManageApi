import { Component, OnInit } from '@angular/core';
import CompanyService from '../shared/api/company.service';
import {Company} from '../shared/models/Company';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
  companies: Array<Company>;

  constructor(private companyService: CompanyService) {}

  ngOnInit() {
    this.companyService.getAll().subscribe(data => {
      this.companies = data;
    });
  }
}