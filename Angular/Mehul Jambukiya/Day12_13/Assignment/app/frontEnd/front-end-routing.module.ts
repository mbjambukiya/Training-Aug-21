import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HtmlWorkComponent } from './html/html-work/html-work.component';
import { CssWorkComponent } from './css/css-work/css-work.component';
import { JsWorkComponent } from './js/js-work/js-work.component';
import { HtmlDay1Component } from './html/html-day1/html-day1.component';
import { CssDay1Component } from './css/css-day1/css-day1.component';
import { CssDay2Component } from './css/css-day2/css-day2.component';
import { CssDay3Component } from './css/css-day3/css-day3.component';
import { CssDay4Component } from './css/css-day4/css-day4.component';
import { CssDay5Component } from './css/css-day5/css-day5.component';
import { JsDay1Component } from './js/js-day1/js-day1.component';
import { JsDay2Component } from './js/js-day2/js-day2.component';
import { JsDay3Component } from './js/js-day3/js-day3.component';
import { JsDay4Component } from './js/js-day4/js-day4.component';
import { JsDay5Component } from './js/js-day5/js-day5.component';
import { JsDay6Component } from './js/js-day6/js-day6.component';

const routes: Routes = [
  {
    path: 'html', component: HtmlWorkComponent,
    children: [
      { path: 'day1', component: HtmlDay1Component }
    ]
  },
  {
    path: 'css', component: CssWorkComponent,
    children: [
      { path: 'day1', component: CssDay1Component },
      { path: 'day2', component: CssDay2Component },
      { path: 'day3', component: CssDay3Component },
      { path: 'day4', component: CssDay4Component },
      { path: 'day5', component: CssDay5Component },
    ]
  },
  {
    path: 'js', component: JsWorkComponent,
    children: [
      { path: 'day1', component: JsDay1Component },
      { path: 'day2', component: JsDay2Component },
      { path: 'day3', component: JsDay3Component },
      { path: 'day4', component: JsDay4Component },
      { path: 'day5', component: JsDay5Component },
      { path: 'day6', component: JsDay6Component },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FrontEndRoutingModule { }