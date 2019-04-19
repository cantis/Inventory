import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ItemTypeGetComponent } from './itemType-get/itemType-get.component';
import { ItemTypeAddComponent } from './itemType-add/itemType-add.component';
import { ItemTypeEditComponent } from './itemType-edit/itemType-edit.component';
import { ItemTypeService } from './services/itemType.service';


@NgModule({
   declarations: [
      AppComponent,
      ItemTypeGetComponent,
      ItemTypeAddComponent,
      ItemTypeEditComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule
   ],
   providers: [
      ItemTypeService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
