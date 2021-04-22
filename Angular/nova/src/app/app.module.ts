import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'

import{FormsModule,ReactiveFormsModule} from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {NovaModelsComponent} from './NovaModel/nova-models/nova-models.component'
import { NovaModelComponent } from './NovaModel/nova-model/nova-model.component';
import { TextComponent } from './Texts/text/text.component';
import {NovaModelPostFormComponent} from '../app/NovaModel/nova-model-post-form/nova-model-post-form.component'
@NgModule({
  declarations: [ 
    NovaModelPostFormComponent,
    AppComponent,
    NovaModelComponent,
    NovaModelsComponent,
    TextComponent
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
