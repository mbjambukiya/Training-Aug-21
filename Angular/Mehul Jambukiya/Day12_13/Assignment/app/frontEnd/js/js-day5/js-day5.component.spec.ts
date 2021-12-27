import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JsDay5Component } from './js-day5.component';

describe('JsDay5Component', () => {
  let component: JsDay5Component;
  let fixture: ComponentFixture<JsDay5Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JsDay5Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JsDay5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
