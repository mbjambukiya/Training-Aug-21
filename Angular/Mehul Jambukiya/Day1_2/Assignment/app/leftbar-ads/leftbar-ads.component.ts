import { Component, OnInit } from '@angular/core';

type Advertisement={
  id:number
  company:string
  description:string
}
@Component({
  selector: 'app-leftbar-ads',
  templateUrl: './leftbar-ads.component.html',
  styleUrls: ['./leftbar-ads.component.css']
})
export class LeftbarAdsComponent implements OnInit {
  ads:Advertisement[]=[
    {id:1,company:"AAA",description:"This is a very good and useful product."},
    {id:2,company:"BBB",description:"This is a very good and useful product."},
    {id:3,company:"CCC",description:"This is a very good and useful product."},
    {id:4,company:"DDD",description:"This is a very good and useful product."}
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
