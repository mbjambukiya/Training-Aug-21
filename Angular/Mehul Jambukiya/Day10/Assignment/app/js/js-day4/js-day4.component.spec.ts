import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JsDay4Component } from './js-day4.component';

describe('JsDay4Component', () => {
  let component: JsDay4Component;
  let fixture: ComponentFixture<JsDay4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JsDay4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JsDay4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
