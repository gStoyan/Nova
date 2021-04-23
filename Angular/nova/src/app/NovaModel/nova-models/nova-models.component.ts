import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {NovaModelService} from '../../services/nova-model.service';
import {TextsService} from '../../services/texts.service';

@Component({
  selector: 'app-nova-models',
  templateUrl: './nova-models.component.html',
  styleUrls: ['./nova-models.component.css']
})
export class NovaModelsComponent implements OnInit {
  public novaModels
  public textModel
  constructor(private route : ActivatedRoute,
              private novaServices: NovaModelService,
              private textServices: TextsService) { }

  ngOnInit(): void {
    this.novaServices.GetNovaModels()
        .subscribe(data=>{
          this.novaModels = data
          console.log(data)
        })
  }
}
