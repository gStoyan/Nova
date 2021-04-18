import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class NovaModelService {
  private path = 'https://localhost:5001/api/'
  private novaModel = 'NovaModel/'
  private novaModels = 'NovaModels'
  constructor(private http: HttpClient) { }

  GetNovaModels(){
    return this.http.get(this.path + this.novaModels);
  }

  GetNovaModel(id){
    return this.http.get(this.path + this.novaModel + id )
  }
}


