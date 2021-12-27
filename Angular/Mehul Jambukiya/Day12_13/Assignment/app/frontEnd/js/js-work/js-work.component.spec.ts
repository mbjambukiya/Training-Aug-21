import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JsWorkComponent } from './js-work.component';

describe('JsWorkComponent', () => {
  let component: JsWorkComponent;
  let fixture: ComponentFixture<JsWorkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JsWorkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JsWorkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
