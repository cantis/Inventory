import { Component, OnInit } from '@angular/core';
import { ItemTypeService } from '../services/itemType.service';
import ItemType from '../models/ItemType';

@Component({
  selector: 'app-itemType-get',
  templateUrl: './itemType-get.component.html',
  styleUrls: ['./itemType-get.component.css']
})
export class ItemTypeGetComponent implements OnInit {

  constructor(private api: ItemTypeService) { }

  data: ItemType[] = [];
  isLoadingResults = true;

  ngOnInit() {
    this.api.getItemTypes()
      .subscribe(res => {
        this.data  = res;
        console.log(this.data);
        this.isLoadingResults = false;
      }, err => {
        this.isLoadingResults = false;
      });
  }

}
