import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ItemTypeService {

  uri = 'https://localhost:44303/api/itemtypes';

  constructor(private http: HttpClient) { }

  addItemType(description: string, sort: number) {
    const obj = {
      description: description,
      sort: sort
    };
    console.log(obj);
    this.http.post('${this.uri}/add', obj).subscribe(res => console.log('Done'));
  }
}
