import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JsDay6Component } from './js-day6.component';

describe('JsDay6Component', () => {
  let component: JsDay6Component;
  let fixture: ComponentFixture<JsDay6Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JsDay6Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JsDay6Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
