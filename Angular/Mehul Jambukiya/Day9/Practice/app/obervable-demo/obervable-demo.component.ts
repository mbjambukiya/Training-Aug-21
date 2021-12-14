import { Component, OnInit } from '@angular/core';
import { UseObservableService } from '../use-observable.service';

@Component({
  selector: 'app-obervable-demo',
  templateUrl: './obervable-demo.component.html',
  styleUrls: ['./obervable-demo.component.css'],
  providers: [UseObservableService]
})
export class ObervableDemoComponent implements OnInit {
  list: number[] = [];
  value:number=0;
  constructor(private observableService: UseObservableService) { }

  ngOnInit(): void {
  }

  public AddNum(value: number) {
    this.observableService.addNum(value);
    this.list=this.observableService.getList();

    // const numbersObservable = this.observableService.getnumbers();

    // numbersObservable.subscribe((numberlist: any[]) => {
    //   this.list = numberlist;
    // });

  }

}