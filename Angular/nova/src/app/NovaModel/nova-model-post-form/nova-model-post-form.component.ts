import { Component, OnInit } from '@angular/core';
import{FormGroup,FormControl} from "@angular/forms";
import { NovaPostModel } from '../models/NovaPostModel';
import {NovaModelService} from '../../services/nova-model.service';

@Component({
  selector: 'app-nova-model-post-form',
  templateUrl: './nova-model-post-form.component.html',
  styleUrls: ['./nova-model-post-form.component.css']
})
export class NovaModelPostFormComponent implements OnInit {
  model: NovaPostModel
  novaForm = new FormGroup({
    'name': new FormControl('')
  })
  constructor(private novaServices: NovaModelService) { }

  ngOnInit(): void {
  }
  create(){
    this.model = new NovaPostModel(this.novaForm.get('name').value,0,0,0,0)  
    this.novaServices.PostNovaModel(this.model)
  }
}
