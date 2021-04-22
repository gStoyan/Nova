import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TextsService {
  private port = 44385;
  private path = 'https://localhost:'+this.port+'/api/';
  private LastNova = "Texts/Nova/"
  constructor(private http: HttpClient) { }

  public GetLastNovaText(novaId){
    return this.http.get(this.path + this.LastNova + novaId )
  }
}
