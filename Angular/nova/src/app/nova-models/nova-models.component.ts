import { Component, OnInit } from '@angular/core';

import {NovaModelService} from '../services/nova-model.service';

@Component({
  selector: 'app-nova-models',
  templateUrl: './nova-models.component.html',
  styleUrls: ['./nova-models.component.css']
})
export class NovaModelsComponent implements OnInit {
  public novaModels
  constructor(private novaServices: NovaModelService) { }

  ngOnInit(): void {
    this.novaServices.GetNovaModels()
        .subscribe(data=>{
          this.novaModels = data
          console.log(data)
        })
  }

}
