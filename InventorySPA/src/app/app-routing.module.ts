import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ItemTypeEditComponent } from './itemType-edit/itemType-edit.component';
import { ItemTypeAddComponent } from './itemType-add/itemType-add.component';
import { ItemTypeGetComponent } from './itemType-get/itemType-get.component';

const routes: Routes = [
    {
      path: 'itemtype/add',
      component: ItemTypeAddComponent
    },
    {
      path: 'itemtype/edit/:id',
      component: ItemTypeEditComponent
    },
    {
      path: 'itemtype',
      component: ItemTypeGetComponent
    }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
