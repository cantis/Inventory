import { Component, OnInit } from '@angular/core';
import { ItemTypeService } from '../services/itemType.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-itemType-add',
  templateUrl: './itemType-add.component.html',
  styleUrls: ['./itemType-add.component.css']
})
export class ItemTypeAddComponent implements OnInit {
  constructor(public service: ItemTypeService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null ) {
      form.form.reset();
    }
    this.service.formData = {
      description: '',
      sort: 0
    };
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.addItemType().subscribe(
      result => {
        this.resetForm(form);
      },
      error => {
        console.log(error);
      });
  }
}
