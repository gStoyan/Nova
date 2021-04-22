import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule,HttpHeaders} from '@angular/common/http';
import {NovaPostModel} from '../NovaModel/models/NovaPostModel';

@Injectable({
  providedIn: 'root'
})
export class NovaModelService {
  private port = 44385;
  private path = 'https://localhost:'+this.port+'/api/';
  private novaModel = 'NovaModel/'
  private novaModels = 'NovaModels'
  
  constructor(private http: HttpClient) { }

  GetNovaModels(){
    return this.http.get(this.path + this.novaModels);
  }

  GetNovaModel(id){
    return this.http.get(this.path + this.novaModel + id )
  }
  PostNovaModel(nova: NovaPostModel){
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization: 'my-auth-token'
      })
    };
    let body = JSON.stringify(nova)
    return this.http.post(this.path + this.novaModels, body,httpOptions).subscribe();
    
  }
}


