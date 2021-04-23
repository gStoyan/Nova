import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";

import {NovaModelService} from '../../services/nova-model.service';

@Component({
  selector: 'app-nova-model',
  templateUrl: './nova-model.component.html',
  styleUrls: ['./nova-model.component.css']
})
export class NovaModelComponent implements OnInit {
  public novaModel;
  public test:string
  constructor(private route: ActivatedRoute,
    private novaServices: NovaModelService,) { }

  ngOnInit(): void {
    this.route.params.subscribe((params) =>{
      let id = params['id']
      console.log(id)
      this.novaServices.GetNovaModel(id).subscribe(novaModel=>{
        this.novaModel = novaModel
       this.test = id
      })
    })
  }
  getTest(testing:string){
    localStorage.setItem('test',testing)
    console.log(localStorage.getItem('test'))
  }
}
 