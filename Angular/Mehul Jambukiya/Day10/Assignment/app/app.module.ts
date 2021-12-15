import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HtmlDay1Component } from './html/html-day1/html-day1.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
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
import { HomePageComponent } from './home-page/home-page.component';

@NgModule({
  declarations: [
    AppComponent,
    HtmlDay1Component,
    PageNotFoundComponent,
    CssDay1Component,
    CssDay2Component,
    CssDay3Component,
    CssDay4Component,
    CssDay5Component,
    JsDay1Component,
    JsDay2Component,
    JsDay3Component,
    JsDay4Component,
    JsDay5Component,
    JsDay6Component,
    HomePageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
