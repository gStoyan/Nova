import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NovaModelPostFormComponent } from './NovaModel/nova-model-post-form/nova-model-post-form.component';
import { NovaModelComponent } from './NovaModel/nova-model/nova-model.component';
import {NovaModelsComponent} from './NovaModel/nova-models/nova-models.component';
import { TextComponent } from './Texts/text/text.component';

const routes: Routes = [
  {path: 'NovaModels', component: NovaModelsComponent},
  {path: 'NovaModel', component: NovaModelPostFormComponent},
  {path:'NovaModel/:id',component:NovaModelComponent},
  {path:'Text/:novaId',component:TextComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
