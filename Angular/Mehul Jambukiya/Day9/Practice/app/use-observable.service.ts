import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class UseObservableService {

  constructor() { }

  list: number[] = [];

  public addNum(num: number) {
    this.list.push(num);
    console.log("addNum");
  }

  public getList() {
    console.log("getList");
    return this.list;
  }

  public getnumbers(): any {
    const numbersObservable = new Observable(observer => {
      setTimeout(() => {
        observer.next(this.list);
      }, 1000);
    });

    return numbersObservable;
  }


}