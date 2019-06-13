import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import ItemType from '../models/ItemType';

@Injectable({
  providedIn: 'root'
})
export class ItemTypeService {
  formData: ItemType;
  readonly rootURL = 'https://localhost:44303/api/itemtypes';

  constructor(private http: HttpClient) { }

  addItemType() {
    console.log(this.formData);
    return this.http.post( '${this.rootURL}/add', this.formData);
  }

  getItemTypes(): Observable<ItemType[]>  {
    const result = this.http.get<ItemType[]>(this.rootURL);
    console.log(result);
    return result;
  }
}
