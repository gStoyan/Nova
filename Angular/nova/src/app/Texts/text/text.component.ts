import { Component, OnInit } from '@angular/core';
import { TextsService } from "../../services/texts.service"

import {ActivatedRoute} from "@angular/router";
@Component({
  selector: 'app-text',
  templateUrl: './text.component.html',
  styleUrls: ['./text.component.css']
})
export class TextComponent implements OnInit {

  public textModel;
  constructor(private route: ActivatedRoute,
              private textServices: TextsService) { }

  ngOnInit(): void {
   
     
  }

}
