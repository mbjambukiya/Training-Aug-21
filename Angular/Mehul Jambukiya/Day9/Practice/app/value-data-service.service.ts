import { Injectable,Inject } from '@angular/core';

export const API_URL:string="api url"
@Injectable({
  providedIn: 'root'
})
export class ValueDataServiceService {

  constructor(@Inject(API_URL) private apiUrl:string) { }

  get():void{
    console.log(`calling ${this.apiUrl}...`)
  }
}
