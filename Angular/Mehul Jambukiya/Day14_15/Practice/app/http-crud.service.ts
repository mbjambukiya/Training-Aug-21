import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICity } from './ICity';

@Injectable({
  providedIn: 'root'
})
export class HttpCrudService {
  // url:string=""
  endPoint:string="/api/city/"

  constructor(private http: HttpClient) {
  }

  getAllCity():Observable<ICity[]> {
    return this.http.get<ICity[]>(this.endPoint);
  }

  getCityById(id: number):Observable<ICity> {
    return this.http.get<ICity>(this.endPoint + id)
  }

  addCity(city: any):Observable<any> {
    let headers = new HttpHeaders();
    headers.append('Content-Type', 'application/json');
    return this.http.post(this.endPoint, city, {headers:headers});
  }

  editCity(city: any) {
    return this.http.put(this.endPoint, city)
  }

  deleteCity(id: number) {
    return this.http.delete(this.endPoint + id)
  }

}
