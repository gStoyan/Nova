import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NovaModelComponent } from './nova-model/nova-model.component';
import {NovaModelsComponent} from '../app/nova-models/nova-models.component';

const routes: Routes = [
  {path: '', component: NovaModelsComponent},
  {path:'NovaModels:id',component:NovaModelComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
